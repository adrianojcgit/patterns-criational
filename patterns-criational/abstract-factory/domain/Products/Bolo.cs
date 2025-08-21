using abstract_factory.domain.enums;

namespace abstract_factory.domain.Products
{
    public abstract class Bolo : MassaBase
    {
        public Bolo(string nome, TipoMassa tipo) : base(nome, tipo)
        {
        }
    }
}