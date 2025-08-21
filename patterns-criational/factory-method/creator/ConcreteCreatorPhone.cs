using factory_method.product;

namespace factory_method.creator
{
    public class ConcreteCreatorPhone : Creator
    {
        public override Product Create()
        {
            return new ConcreteProductPhone();
        }
    }
}