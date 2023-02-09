using System;
using System.Collections.Generic;
using System.Text;

namespace Homework
{
    internal class Employee
    {
        public string FullName;
        protected double _salary=300;
        public virtual double Salary
        {
            get
            {
                return _salary;
            }
            set
            {
                if (value >= 300)
                    _salary = value;
            }
        }

        public void ShowInfo()
        {
            Console.WriteLine($"FullName: {FullName} - Salary: {_salary}");
        }

    }
}
