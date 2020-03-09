const mongoose = require('mongoose');
const Schema = mongoose.Schema;

const userSchema = new Schema({
    username: String,
    password: String,

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
    timestamps: {
        createdAt: 'created_at',
        updatedAt: 'updated_at'
    }
});

const User = mongoose.model('User', userSchema);
module.exports = User;