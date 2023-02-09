using System;
using System.Collections.Generic;
using System.Text;

namespace Homework
{
    internal class Engineer:Employee
    {
        public override double Salary
        {
            get
            {
                return _salary;
            }
            set
            {
                if (value >= 1000)
                    _salary = value;
            }
        }
    }
}
