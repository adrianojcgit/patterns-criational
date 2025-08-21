using abstract_factory.domain.enums;
using abstract_factory.domain.Products;

namespace abstract_factory.factory
{
    public sealed class PizzaFactory  : MassaAbstractFactory
    {
        public override MassaBase CriaMassa(TipoMassa tipoMassa)
        {
            var tipoPizza = (TipoPizza)tipoMassa;
            switch (tipoPizza)
            {
                case TipoPizza.Mussarela:
                    {
                        return new PizzaMussarela();
                    }
                case TipoPizza.Calabreza:
                    {
                        return new PizzaCalabreza();
                    }
                default:
                    throw new ArgumentOutOfRangeException("Tipo não implementado");
            }
        }
    }
}