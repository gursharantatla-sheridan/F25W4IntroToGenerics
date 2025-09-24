namespace ListExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee(101, "John", 5000);
            Employee emp2 = new Employee(102, "Anne", 7000);
            Employee emp3 = new Employee(103, "Mark", 3000);

            List<Employee> lstEmps = new List<Employee>();
            lstEmps.Add(emp1);
            lstEmps.Add(emp2);
            lstEmps.Add(emp3);

            lstEmps.Insert(1, emp3);
            lstEmps.Remove(emp3);
            //lstEmps.Clear();

            foreach (var e in lstEmps)
                Console.WriteLine(e);
        }
    }
}
