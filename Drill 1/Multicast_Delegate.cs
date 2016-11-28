using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {
        public delegate void Del(string message);

        public static void DelMethod(string message)
        {
            Console.WriteLine(message);
        }

        public static void DelMethod2(string message2)
        {
            Console.WriteLine(message2);
        }



        static void Main(string[] args)
        {
            Del thing1, thing2, multi;
            thing1 = DelMethod;
            thing2 = DelMethod2;

            multi = thing1 + thing2;

            multi("Twice");
        }
    }
}
