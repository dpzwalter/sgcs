const { Schema, model } = require('mongoose');

const ItemSchema = new Schema({
    estado: {
        type: String,
        required: true
    },

    descripcion: {
        type: String,
        required: true
    },

    version: {
        type: String,
        required: true
    },

    observacion: {
        type: String,
        required: true
    },

    dependencia: {
        type: String,
        required: true
    },

    prioridad: {
        type: String,
        required: true
    },

    fecha_inicio: {
        type: String,
        required: true
    },

    fecha_modificacion: {
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

CompraSchema.plugin(require('mongoose-autopopulate'));

module.exports = model('Item', ItemSchema);