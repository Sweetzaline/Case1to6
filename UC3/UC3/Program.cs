using System;

namespace ConsoleApp3
{
    class Program
    {
       static void Main(string[] args)
        {
            Console.WriteLine("Question: Add Part time Employee & Wage");
            //Costants
            int IS_PART_TIME = 1;
            int IS_FULL_TIME = 2;
            int EMP_WAGE_PER_HOUR = 1000;
            //Variables
            int empHours = 0;
            int empWage = 0;
            Random random = new Random();
            //Computation
            int empCheck = random.Next(0, 3);

            if (empCheck == IS_PART_TIME)
            {
                empHours = 4;
                Console.WriteLine("Employee work Part-Time.");
            }
            else if (empCheck == IS_FULL_TIME)
            {
                empHours = 8;
                Console.WriteLine("Employee work Full-Time.");
            }
            else
            {
                empHours = 0;
                Console.WriteLine("Employee Not Working.");
            }
            empWage = empHours * EMP_WAGE_PER_HOUR;
            Console.WriteLine("Emp Wage: " + empWage);
        }
    }
}
