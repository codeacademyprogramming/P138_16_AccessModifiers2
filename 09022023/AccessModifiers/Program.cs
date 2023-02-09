using System;
using Lesson;
using ClassLibrary.Classes;


namespace AccessModifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product pr = new Product();

            Store st = new Store();

            Student std = new Student();

            Human human = new Human();

            human.Name = "Hikmet";
            human.Surname = "Abbasov";
        }
    }
}
