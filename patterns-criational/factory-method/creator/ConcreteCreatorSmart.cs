using factory_method.product;

namespace factory_method.creator
{
    public class ConcreteCreatorSmart : Creator
    {
        public override Product Create()
        {
            return new ConcreteProductSmart();
        }
    }
}