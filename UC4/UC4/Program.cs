using System;

namespace UC4
{
    class Program
    {
        //Constants
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public const int EMP_WAGE_PER_HOUR = 500;
        static void Main(string[] args)
        {
            Console.WriteLine("Question: Solving using Switch Case");
            //Variables
            int empHours = 0;
            int empWage = 0;
            Random random = new Random();
            //Computations
            int empCheck = random.Next(0, 3);
            switch (empCheck)
            {
                case IS_PART_TIME:
                    empHours = 4;
                    Console.WriteLine("Employee work Part-time. ");
                    break;

                case IS_FULL_TIME:
                    empHours = 8;
                    Console.WriteLine("Employee work Full-time. ");
                    break;

                default:
                    empHours = 0;
                    Console.WriteLine("Employee don't work. ");
                    break;
            }
            empWage = empHours * EMP_WAGE_PER_HOUR;
            Console.WriteLine("Employee's Wage: " + empWage);
        }
    }
}
