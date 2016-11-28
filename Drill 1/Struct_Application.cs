using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    class Program
    {
        public struct Numbers
        {
            public int x, y, z;

            public Numbers(int num1, int num2, int num3)
            {
                x = num1;
                y = num2;
                z = num3;
            }
        }
        static void Main(string[] args)
        {
            Numbers number = new Numbers();
            number.z = 12;
            Console.WriteLine(number.z);
        }
    }
}
