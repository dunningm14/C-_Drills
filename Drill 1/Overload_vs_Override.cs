using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overload_vs_Override
//Overloading
    public class test
    {
        public void getStuff(int id)
        { }
        public void getStuff(string name)
        { }
    }

//Overriding
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

