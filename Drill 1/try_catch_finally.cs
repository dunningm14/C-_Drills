using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class tryCatchFinally 
    {
        static void Main(string[] args)
        {
            try
            {
                int a = 10;
                int b = 20;
                int z = a + b;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Executed");
            }
        }
    }
}
