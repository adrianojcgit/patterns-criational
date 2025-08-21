using abstract_factory.domain.enums;
using abstract_factory.domain.Products;

namespace abstract_factory.factory
{
    //AbstractFactory
    public abstract class MassaAbstractFactory
    {
        public abstract MassaBase CriaMassa(TipoMassa tipoMassa);
        public static MassaAbstractFactory CriaFabricaMassas(TipoMassa tipoMassa)
        {
            switch (tipoMassa)
            {
                case TipoMassa.Pizza:
                    {
                        return new PizzaFactory();
                    }
                case TipoMassa.Bolo:
                    {
                        return new BoloFactory();
                    }
                default:
                    throw new ArgumentOutOfRangeException(nameof(tipoMassa));
            }

        }
    }
}