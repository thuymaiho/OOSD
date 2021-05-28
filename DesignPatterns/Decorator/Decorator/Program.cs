
using System;
using static System.Console;

namespace P01_Concept
{
    interface IComponent
    {
        string Operation();
    }

    class Component : IComponent
    {
        public string Operation()
        {
            return "Hi, I have some advice for you !";
        }
    }

    class DecoratorA : IComponent
    {
        private readonly IComponent _component;

        public DecoratorA(IComponent component)
        {
            _component = component;
        }

        // coi như "kế thừa" phương thức này từ object gốc
        // nếu muốn bạn có thể "giả lập ghi đè" bằng cách thay đổi nội dung phương thức này
        public string Operation()
        {
            return _component.Operation();
        }

        // bổ sung phương thức này cho object gốc
        public string AddedBehavior()
        {
            return "You need to exercise more often";
        }
    }

    class DecoratorB : IComponent
    {
        private readonly IComponent _component;

        public DecoratorB(IComponent component)
        {
            _component = component;
        }

        // giả lập ghi đè Operation
        public string Operation()
        {
            var s = _component.Operation();
            return $"{s}. you can even buy weight loss pills to use";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Title = "DECORATOR DESIGN PATTERN";

            IComponent orgComponent = new Component();
            DecoratorA aComponent = new DecoratorA(orgComponent);
            DecoratorB bComponent = new DecoratorB(orgComponent);
            DecoratorA abComponent = new DecoratorA(bComponent);


            Console.Write("enter your weight = ");
            string  a= Console.ReadLine();





            ForegroundColor = ConsoleColor.Green;
            WriteLine($"Original object: {orgComponent.Operation()}");
            if(int.Parse(a)>=60)
            {
              

                ForegroundColor = ConsoleColor.Cyan;
                WriteLine($"2 Decorator object: {bComponent.Operation()}");
            }
            else
            {
                ForegroundColor = ConsoleColor.Yellow;
                WriteLine($"1 Decorator object: {aComponent.Operation()}. {aComponent.AddedBehavior()}");
            }
           

            //ForegroundColor = ConsoleColor.Magenta;
            //WriteLine($"AB Decorator object: {abComponent.Operation()}");

            ReadKey();
        }
    }
}