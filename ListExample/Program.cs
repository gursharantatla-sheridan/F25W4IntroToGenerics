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


            // Searching

            // IndexOf

            int index = lstEmps.IndexOf(emp2);

            if (index >= 0)
                Console.WriteLine("Item exists");
            else
                Console.WriteLine("Item doesn't exist");


            // Contains

            if (lstEmps.Contains(emp2))
                Console.WriteLine("Item exists");
            else
                Console.WriteLine("Item doesn't exist");



            // Exists

            if (lstEmps.Exists(e => e.Name.StartsWith("A")))
                Console.WriteLine("Item exists");
            else
                Console.WriteLine("Item doesn't exist");


            // Find

            var emp = lstEmps.Find(e => e.Salary > 4000);

            if (emp != null)
                Console.WriteLine(emp);
            else
                Console.WriteLine("Item doesn't exist");
        }
    }
}
