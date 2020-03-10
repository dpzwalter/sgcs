const LocalStrategy = require('passport-local').Strategy;

const User = require('../app/models/user');

module.exports = function (passport) {
  // requerido para sesiones de inicio de sesión persistentes
  // el passport necesita capacidad para serializar y deserializar usuarios fuera de sesión
  passport.serializeUser(function (user, done) {
    done(null, user.id);
  });

  // usado para deserializar al usuario
  passport.deserializeUser(function (id, done) {
    User.findById(id, function (err, user) {
      done(err, user);
    });
  });

  // Signup
  passport.use('local-signup', new LocalStrategy({
    // de forma predeterminada, local strategy usa nombre de usuario y contraseña, lo anularemos con el correo electrónico
    usernameField: 'email',
    passwordField: 'password',
    passReqToCallback : true // nos permite pasar la solicitud completa a la devolución de llamada
  },
  function (req, email, password, done) {
    User.findOne({'local.email': email}, function (err, user) {
      if (err) {
        return done(err);
      }
      if (user) {
        return done(null, false, req.flash('signupMessage', 'the email is already taken'));
      } else {
        var newUser = new User();
        newUser.local.email = email;
        newUser.local.password = newUser.generateHash(password);
        newUser.save(function (err) {
          if (err) { throw err; }
          return done(null, newUser);
        });
      }
    });
  }));

  // login
  // estamos usando estrategias con nombre ya que tenemos una para iniciar sesión y otra para registrarse
  // por defecto, si no hubiera nombre, simplemente se llamaría 'local
  passport.use('local-login', new LocalStrategy({
    usernameField: 'email',
    passwordField: 'password',
    passReqToCallback: true
  },
  function (req, email, password, done) {
    User.findOne({'local.email': email}, function (err, user) {
      if (err) { return done(err); }
      if (!user) {
        return done(null, false, req.flash('loginMessage', 'No User found'))
      }
      if (!user.validPassword(password)) {
        return done(null, false, req.flash('loginMessage', 'Wrong. password'));
      }
      return done(null, user);
    });
  }));
}