// See https://aka.ms/new-console-template for more information
using DecoratorDesignPattern;

IPizza pizza = new Pizza();
IPizza cheeseDecorator = new CheesDecorator(pizza);
IPizza tomatoDecorator = new TomatoDecorator(cheeseDecorator);
IPizza OnionDecorator = new OnionDecorator(tomatoDecorator);
IPizza paneerDecorator = new PaneerDecorator(tomatoDecorator);
Console.WriteLine(paneerDecorator.GetPizzaType());