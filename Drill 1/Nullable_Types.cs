using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            int? x = 7;

            if (x.HasValue)
            {
                Console.WriteLine("x = " + x.Value);
            }
            else
            {
                Console.WriteLine("x = Null");
            }
        }
    }
}
