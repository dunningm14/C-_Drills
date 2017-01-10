/*************************************************************************************************************************
Author: Madison Dunning
Date: 11/30/16
OS: Windows 10
Purpose: To demonstrate the creation of a sealed class   
         
**************************************************************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sealed_Class
{
    class Class1
    {
        static void Main(string[] args)
        {
            SealedClass sealedCls = new SealedClass();
            int total = sealedCls.Add(4, 5);
            Console.WriteLine("Total = " + total.ToString());
        }
    }
    // Sealed class
    sealed class SealedClass
    {
        public int Add(int x, int y)
        {
            return x + y;
        }
    }

}
