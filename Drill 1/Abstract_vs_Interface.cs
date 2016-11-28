using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class Program
    {
        interface ISleep
        {
            void sleep();
        }
        abstract class Animal
        {
            abstract public void Run();
            abstract public void Eat();
        }
        // A class can inherit a method from an interface
        // or methods and properties from an abstract class
        class Bear : Animal, ISleep
        {
            public override void Eat()
            {
                Console.WriteLine("Munch.");
            }

            public override void Run()
            {
                Console.WriteLine("Panting.");
            }

            public void sleep()
            {
                Console.WriteLine("Zzzzz.");
            }
        }
        static void Main(string[] args)
        {

        }
    }
}
