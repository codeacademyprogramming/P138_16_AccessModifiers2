using System;

namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Engineer[] engineers = new Engineer[0];


            //for (int i = 0; i < engineers.Length; i++)
            //{
            //    Console.Write("FullName: ");
            //    string fullname = Console.ReadLine();

            //    double salary;
            //    do
            //    {
            //        Console.Write("Salary: ");
            //        string salaryStr = Console.ReadLine();
            //        salary = Convert.ToDouble(salaryStr);
            //    } while (salary<1000);

            //    Engineer eng = new Engineer
            //    {
            //        FullName = fullname,
            //        Salary = salary
            //    };

            //    engineers[i] = eng;
            //}

            string ch;
            do
            {
                Console.Write("FullName: ");
                string fullname = Console.ReadLine();
                double salary;
                do
                {
                    Console.Write("Salary: ");
                    string salaryStr = Console.ReadLine();
                    salary = Convert.ToDouble(salaryStr);
                } while (salary < 1000);

                Engineer eng = new Engineer
                {
                    FullName = fullname,
                    Salary = salary
                };

                Array.Resize(ref engineers, engineers.Length+1);
                engineers[engineers.Length - 1] = eng;


                do
                {
                    Console.WriteLine("Isci elave etmek isteyirsinizmi? y/n");
                    ch = Console.ReadLine();
                } while (ch !="y" && ch!="n");

               

            } while (ch == "y");
           



            double sum = 0;

            for (int i = 0; i < engineers.Length; i++)
            {
                sum += engineers[i].Salary;
            }

            Console.WriteLine(sum/engineers.Length);

        }
    }
}
