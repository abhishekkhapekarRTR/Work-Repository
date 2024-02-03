using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern
{
    public class DecoratorImplementation
    {
    }

    //base interface
    public interface IPizza
    {
        string GetPizzaType();
    }

    //Concreate Implementation
    public class Pizza : IPizza
    {
        public string GetPizzaType()
        {
            return "This is a normal pizza";
        }
    }

    //base decorator
    class PizzaDecorator : IPizza
    {
        private readonly IPizza _pizza;

        public PizzaDecorator(IPizza pizza)
        {
            _pizza = pizza;
        }

        public virtual string GetPizzaType()
        {
            return _pizza.GetPizzaType();
        }
    }

    //Concreate decorator
    class CheesDecorator : PizzaDecorator
    {
        public CheesDecorator(IPizza pizza) : base(pizza) { }

        public override string GetPizzaType()
        {
            string type = base.GetPizzaType();
            type += "\r\n With extra Cheese";
            return type;
        }
    }

    class TomatoDecorator : PizzaDecorator
    {
        public TomatoDecorator(IPizza pizza) : base(pizza) { }

        public override string GetPizzaType()
        {
            string type = base.GetPizzaType();
            type += "\r\n With extra Tomatos";
            return type;
        }
    }

    class OnionDecorator : PizzaDecorator
    {
        public OnionDecorator(IPizza pizza) : base(pizza) { }

        public override string GetPizzaType()
        {
            string type = base.GetPizzaType();
            type += "\r\n With extra Onion";
            return type;
        }
    }

    class PaneerDecorator : PizzaDecorator
    {
        public PaneerDecorator(IPizza pizza) : base(pizza) { }

        public override string GetPizzaType()
        {
            string type = base.GetPizzaType();
            type += "\r\n With extra Paneer";
            return type;
        }
    }

}
