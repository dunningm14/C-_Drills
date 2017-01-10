/*************************************************************************************************************************
Author: Madison Dunning
Date: 11/26/16
OS: Windows 10
Purpose: This was an exercise I did to explore the difference between overloading methods and overriding methods, showing 
         each in operation

**************************************************************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overload_vs_Override
    
/*************************************************************************************************************************

                                                         OVERLOADING

**************************************************************************************************************************/
    public class test
    {
        public void getStuff(int id)
        { }
        public void getStuff(string name)
        { }
    }

/*************************************************************************************************************************

                                                         OVERRIDING

**************************************************************************************************************************/
    public class test
    {
        public virtual void getStuff(int id)
        {
            //Get stuff default location
        }
    }

    public class test2 : test
    {
        public override void getStuff(int id)
        {
            //base.getStuff(id);
            //or - Get stuff new location
        }
    }
}

