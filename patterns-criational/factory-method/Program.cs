using factory_method.creator;
using factory_method.product;

Product web = new ConcreteCreatorWeb().Create();
Product smart = new ConcreteCreatorSmart().Create();
Product smartTV = new ConcreteCreatorSmartTV().Create();
Product phone = new ConcreteCreatorPhone().Create();

Console.WriteLine($"Web {web.GetMessageText()}");
Console.WriteLine($"Smart {smart.GetMessageText()}");
Console.WriteLine($"smartTV {smartTV.GetMessageText()}");
Console.WriteLine($"Phone {phone.GetMessageText()}");

Console.ReadLine();