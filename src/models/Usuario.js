const { Schema, model } = require('mongoose');

const UsuarioSchema = new Schema({
    username: {
        type: String,
        required: true
    },

    password: {
        type: String,
        required: true
    },

    nombre: {
        type: String,
        required: true
    },

    cedula: {
        type: String,
        required: true
    },

    telefono: {
        type: String,
        required: true
    },

    fecha_nacimiento: {
        type: String,
        required: true
    }
}, {
    timestamps: false
});

module.exports = model('Usuario', UsuarioSchema);