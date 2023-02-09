using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson
{
    public class Product
    {
        string _name;
        double _price;

        public string Name
        {
            get => _name;
            set
            {
                if (CheckName(value))
                    _name = value;
            }
        }
        public double Price
        {
            get => _price;
            set
            {
                if (value >= 0)
                    _price = value;
            }
        }

        public bool CheckName(string name)
        {
            if (!string.IsNullOrWhiteSpace(name) && name.Length >= 2 && char.IsUpper(name[0]))
                return true;

            return false;
        }


        public double DiscountPercent;
    }
}
