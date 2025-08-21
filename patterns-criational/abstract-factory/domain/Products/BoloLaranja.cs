using abstract_factory.domain.Products;
using abstract_factory.domain.enums;

namespace abstract_factory.factory
{
    public sealed class BoloLaranja : Bolo
    {
        public BoloLaranja() : base("Bolo de Laranja", TipoMassa.Bolo)
        {
            Ingredientes.Add("Com cobertura de calda de laranja");
        }
    }
}