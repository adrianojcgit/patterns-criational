using abstract_factory.domain.enums;

namespace abstract_factory.domain.Products
{
     //AbstractProductB
    public abstract class Pizza : MassaBase
    {
        public Pizza(string nome, TipoMassa tipo) : base(nome, tipo)
        {
        }
    }
}