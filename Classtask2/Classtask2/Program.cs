using System;


namespace Classtask2.Models

{
    class Program
    {

        static void Main(string[] args)
        {

            Employee emp = new Employee("Aysu", 9, 500);
            Employee emp1 = new Employee("Zulfiyye", 9, 500);
            //Console.WriteLine(emp.ShowInfo());
            //Console.WriteLine(emp1.ShowInfo());

            Department d = new Department("dsf", 5);
            d.AddEmployee(emp);
            d.AddEmployee(emp1);

            Console.WriteLine(d[0]);



        }
      

    }
}
