using builder.Product;

namespace builder.Builder
{
    //Builder
    public abstract class ComputadorBuilder
    {
        public abstract void BuildSO();
        public abstract void BuildDispositivos();
        Computador? TipoComputador { get; }
    }
}