namespace factory_method.product
{
    public abstract class Product
    {
        protected string BackgroundColor { get; }
        private readonly string MessageText;

        public Product(string backgroundColor, string messageText)
        {
            BackgroundColor = backgroundColor;
            MessageText = messageText;
        }

        public string GetMessageText()
        {
            return MessageText;
        }
        
    }
}