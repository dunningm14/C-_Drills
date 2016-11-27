using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Derived_Class
{
    public class ParentClass
    {
        public ParentClass()
        {
            Console.WriteLine("Constructs the Parent Class");
        }

        public void print()
        {
            Console.WriteLine("This is the Parent Class");
        }
    }

    public class ChildClass : ParentClass
    {
        public ChildClass()
        {
            Console.WriteLine("This is the Child Class");
        }

        public static void Main()
        {
            ChildClass child = new ChildClass();

            child.print();
        }
    }
}
