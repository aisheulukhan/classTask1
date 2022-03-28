using System;
using System.Collections.Generic;
using System.Text;
using Classtask2.CustomException;

namespace Classtask2.Models
{
    public class Department
    {
        public string Name { get; set; }
        public double EmpoyeeLimit { get; set; }
        private Employee[] _employees=new Employee[0];
        public Employee this[int index]
        {
            get { return _employees[index]; }
            set { _employees[index] = value; }
        }
        public void AddEmployee(Employee employee)
        {
            if (_employees.Length < EmpoyeeLimit)
            {
                Array.Resize(ref _employees, _employees.Length + 1);
                _employees[_employees.Length - 1] = employee;
            }
            else
            {
                throw new CapasityLimitException("Limiti kecdiniz!");
            }
        }
        public Department(string name, double employeeLimit)
        {
            Name = name;
            EmpoyeeLimit = employeeLimit;
        }


    }
}
