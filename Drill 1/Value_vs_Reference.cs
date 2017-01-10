/*************************************************************************************************************************
Author: Madison Dunning
Date: 11/28/16
OS: Windows 10
Purpose: To demonstrate the difference between value types and reference types
         
**************************************************************************************************************************/﻿

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace valueTypesVsReference
{
    class Program
    {
        static void Main(string[] args)
        {
            // this is a value type
            int x = 58;
            // this is a reference type
            int[] numbers = new int[11];
        }
    }
}
