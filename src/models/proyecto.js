const { Schema, model } = require('mongoose');

const ProyectoSchema = new Schema({
    nombre: {
        type: String,
        required: true
    },

    objetivo: {
        type: String,
        required: true
    },

    fecha_inicio: {
        type: String,
        required: true
    },

    fecha_fin: {
        type: String,
        required: true
    },

    estado: {
        type: String,
        required: true
    },

    rol: {
        type: Schema.Types.ObjectId,
        ref: 'Rol',
        autopopulate: true
    },

    linea_base: {
        type: Schema.Types.ObjectId,
        ref: 'LineaBase',
        autopopulate: true
    }
}, {
    timestamps: false
});

CompraSchema.plugin(require('mongoose-autopopulate'));

module.exports = model('Proyecto', ProyectoSchema);