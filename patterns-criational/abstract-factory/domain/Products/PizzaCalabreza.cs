using abstract_factory.domain.enums;

namespace abstract_factory.domain.Products
{
    public sealed class PizzaCalabreza : Pizza
    {
        public PizzaCalabreza() : base("Pizza calabreza", TipoMassa.Pizza)
        {
            Ingredientes.Add("Calabreza em cubos e tomtes em cubos");
        }
    }
}