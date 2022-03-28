using System;
using System.Collections.Generic;
using System.Text;

namespace Classtask2.Models
{
    public class Employee : IPerson
    {
        private static int _id;
        private double _salary;
        public int Id { get; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }

        static Employee()
        {
            _id = 0;
        }
        private Employee()
        {
            ++_id;
            Id = _id;
        }
        public Employee(string name, int age, double salary) : this()
        {
            Name = name;
            Age = age;
            Salary = salary;
        }

       
        public string ShowInfo()
        {
            return $"Id: {Id} Name: {Name} Age: {Age} Salary: {Salary}";
        }
        public override string ToString()
        {
            return ShowInfo();
        }
       
    }
}
