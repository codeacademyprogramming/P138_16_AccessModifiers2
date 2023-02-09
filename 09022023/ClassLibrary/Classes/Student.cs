using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary.Classes
{
    public class Student:Human
    {
        public string GroupNo;

        public Student()
        {
            Name = "Filan";
            Surname = "fdf";

            var hm = new Human();
            hm.Name = "fd";
        }
    }
}
