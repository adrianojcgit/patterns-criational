using abstract_factory.domain.enums;
using abstract_factory.domain.Products;

namespace abstract_factory.factory
{
    public sealed class BoloChocolate : Bolo
    {
        public BoloChocolate() : base("Bolo de Chocolate", TipoMassa.Bolo)
        {
            Ingredientes.Add("Com cobertura de chocolate Nestlé");
        }
    }
}