const { Schema, model } = require('mongoose');

const RolSchema = new Schema({
    descripcion: {
        type: String,
        required: true
    },

    usuario: {
        type: Schema.Types.ObjectId,
        ref: 'Usuario',
        autopopulate: true
    }
}, {
    timestamps: false
});

RolSchema.plugin(require('mongoose-autopopulate'));

module.exports = model('Rol', RolSchema);