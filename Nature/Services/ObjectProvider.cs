namespace Nature.Services
{
    public class ObjectProvider
    {
       
    }

    //base interface
    interface IPizza   // IClassicPlayer
    {
        string GetPizzaType();
    }

    // concrete implementation
    public class Pizza : IPizza   // ClassicPlayer : IClassicPlayer
    {
        public string GetPizzaType()
        {
            return "Pizza Type: Margherita";
        }
    }
    
    // base decorator                      
    class PizzaDecorator : IPizza   // ClassicPlayerDecorator : IClassicPlayer
    {
        protected IPizza _pizza;
        public PizzaDecorator(IPizza pizza)
        {
            _pizza = pizza;
        }
        public virtual string GetPizzaType()
        {
            return _pizza.GetPizzaType();
        }
    }

    // concrete decorator
    class CheeseDecorator : PizzaDecorator   // Character : IClassicPlayer
    {
        public CheeseDecorator(IPizza pizza) : base(pizza)
        {
        }

        public override string GetPizzaType()
        {
            string type = base.GetPizzaType();
            type += "\n extra Cheese added";
            return type;
        }
    }

    class OnieonDecorator : PizzaDecorator
    {
        public OnieonDecorator(IPizza pizza) : base(pizza)
        {
        }

        public override string GetPizzaType()
        {
            string type = base.GetPizzaType();
            type += "\n extra Onieon added";
            return type;
        }
    }

   


}
