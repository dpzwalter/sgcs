const { Schema, model } = require('mongoose');

const LineaBaseSchema = new Schema({
    estado: {
        type: String,
        required: true
    },

    fase: {
        type: String,
        required: true
    },

    estado_fase: {
        type: String,
        required: true
    },

    item: {
        type: Schema.Types.ObjectId,
        ref: 'LineaBase',
        autopopulate: true
    }
}, {
    timestamps: false
});

CompraSchema.plugin(require('mongoose-autopopulate'));

module.exports = model('LineaBase', LineaBaseSchema);