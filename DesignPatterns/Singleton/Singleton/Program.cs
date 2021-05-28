using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            MySingleton mySingleton = MySingleton.Instance;
            mySingleton.DoSomething();
        }
    }
    public class MySingleton
    {
        private static MySingleton instance = new MySingleton();
        private MySingleton() { } 
        public static MySingleton Instance
        { get { return instance; } }
        
        public void DoSomething()
        {
            Console.WriteLine("Calorie and nutrition counters are probably the most popular type of nutrition app. Our main objective is to measure calories consumed and burned by the user in a day. ");
            Console.ReadLine();
        }

    }
}
