using factory_method.product;

namespace factory_method.creator
{
    public class ConcreteCreatorWeb : Creator
    {
        public override Product Create()
        {
            return new ConcreteProductWeb();
        }
    }
}