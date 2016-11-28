using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace usingThis
{
    class Employee
    {
        private string name;
        private string alias;

        // Constructor:
        public Employee(string name, string alias)
        {
            // Use this to qualify the fields, name and alias:
            this.name = name;
            this.alias = alias;
        }
        // Printing method:
        public void printEmployee()
        {
            Console.WriteLine("Name: {0}\nAlias: {1}", name, alias);
        }
    }
    class MainClass
    {
        static void Main()
        {
            // Create objects:
            Employee E1 = new Employee("Mingda Pan", "mpan");

            // Display results:
            E1.printEmployee();
        }
    }
}
