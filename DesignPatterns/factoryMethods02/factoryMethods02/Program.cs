using System;

namespace factoryMethods02
{
    public class ClientApplication
    {
        static void Main()
        {
            Meals factory = null;
            Console.Write("Enter the meals you would like to check: ");
            string car = Console.ReadLine();

            switch (car.ToLower())
            {
                case "chicken":
                    factory = new Chicken(5, 10);
                    break;
                case "beef":
                    factory = new Beef(10, 500);
                    break;
                case "pork":
                    factory = new Pork(500, 1000);
                    break;
                default:
                    break;
            }


            Console.WriteLine("\nNutritional content per 100g : \n");
            Console.WriteLine("Meals Type: "+factory.Name);
            Console.WriteLine("Protein: "+factory.Protein);
            Console.WriteLine("Calories: "+factory.Calories);
            Console.ReadKey();
        }
    }
}
