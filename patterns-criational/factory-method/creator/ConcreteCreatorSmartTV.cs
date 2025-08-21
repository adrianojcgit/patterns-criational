using factory_method.product;

namespace factory_method.creator
{
    public class ConcreteCreatorSmartTV : Creator
    {
        public override Product Create()
        {
            return new ConcreteProductSmartTV();
        }
    }
}