/*************************************************************************************************************************
Author: Madison Dunning
Date: 11/28/16
OS: Windows 10
Purpose: Handling an exception by writing the important data from the exception to a log file on the local
         machine   
         
**************************************************************************************************************************/﻿﻿

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;

class ExceptionApplication
{

    public static void Main()
    {
        int[] table = new int[6] { 10, 11, 12, 13, 14, 15 };
        int idx = 6;

        M(table, idx);
    }

    public static void M(int[] table, int idx)
    {
        Console.WriteLine("Accessing element {0}: {1}",
                           idx, table[idx]);
    }

}
