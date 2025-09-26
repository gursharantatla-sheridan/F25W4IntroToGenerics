using ListExample;

namespace DictionaryExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Employee class is in ListExample project
            // we added the reference to that project
            // included that namespace at the top using the "using" statement

            Employee emp1 = new Employee(101, "John", 5000);
            Employee emp2 = new Employee(102, "Anne", 7000);
            Employee emp3 = new Employee(103, "Mark", 3000);


        }
    }
}
