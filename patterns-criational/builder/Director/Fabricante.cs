using builder.Builder;

namespace builder.Director
{
    public class Fabricante
    {
      //Director        
        public void Build(ComputadorBuilder computadorBuilder)
        {
            computadorBuilder.BuildDispositivos();
            computadorBuilder.BuildSO();
        } 
    }
}