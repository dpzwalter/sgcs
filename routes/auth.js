const express = require("express");
const passport = require('passport');
const router = express.Router();
const User = require("../models/User");

// Bcrypt to encrypt passwords
const bcrypt = require("bcrypt");
const bcryptSalt = 10;


router.get("/login", (req, res, next) => {
    res.render("auth/login", { "message": req.flash("error"), title: 'Login' });
});

router.post("/login", passport.authenticate("local", {
    successRedirect: "/",
    failureRedirect: "/auth/login",
    failureFlash: true,
    passReqToCallback: true
}));

router.get("/signup", (req, res, next) => {
    res.render("auth/signup", {title: 'Signup'});
});

router.post("/signup", (req, res, next) => {
    const { username, password, nombre, cedula, telefono, fecha_nacimiento } = req.body;

    if (!nombre) {
        res.json({
            success: false,
            message: 'Indicate name'
        });
    }

    if (!cedula) {
        res.json({
            success: false,
            message: 'Indicate CI'
        });
    }

    if (!telefono) {
        res.json({
            success: false,
            message: 'Indicate phone number'
        });
    }

    if (!fecha_nacimiento) {
        res.json({
            success: false,
            message: 'Indicate date of birth'
        });
    }

    if (username === "" || password === "") {
        res.render("auth/signup", { message: "Indicate username and password" });
        return;
    }

    User.findOne({ username }, "username", (err, user) => {
        if (user !== null) {
            res.render("auth/signup", { message: "The username already exists" });
            return;
        }

        const salt = bcrypt.genSaltSync(bcryptSalt);
        const hashPass = bcrypt.hashSync(password, salt);

        const newUser = new User({
            username,
            password: hashPass,
            nombre,
            cedula,
            telefono,
            fecha_nacimiento
        });

        newUser.save()
            .then(() => {
                res.redirect("/");
            })
            .catch(err => {
                res.render("auth/signup", { message: "Something went wrong" });
            })
    });
});

router.get("/logout", (req, res) => {
    req.logout();
    res.redirect("/");
});

module.exports = router;