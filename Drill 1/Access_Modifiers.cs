/*************************************************************************************************************************
Author: Madison Dunning
Date: 11/26/16
OS: Windows 10
Purpose: Demonstrate the use of the access modifiers: public, protected, internal, private, protected internal. 

**************************************************************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill2
{
    class one
    {
        public int number()
        {
            return 1;
        }
         //Public: This can be used anywhere
    }
    class two
    {
        private int number2()
        {
            return 1;
        }
        //Private: can only be used within its class (ie "two")
    }
    class three
    {
        protected int number3()
        {
            return 1;
        }
        // Protected: Can be used in any class derived from this base class
    }
    class four
    {
        internal int number4()
        {
            return 1;
        }
        // Internal: Only used in this assembly and class
    }
    class five
    {
        internal protected int number5()
        {
            return 1;
        }
        // Internal Protected: can be used anywhere in the assembly
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
