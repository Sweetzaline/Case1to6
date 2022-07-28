using System;

namespace UC5
{
    class Program
    {
        //Constants
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public const int EMP_WAGE_PER_HOUR = 500;
        public const int NUM_WORKING_DAYS = 20;
        static void Main(string[] args)
        {
            Console.WriteLine("Calculating Wages for a Month assuming 20 Working Days in a Month");
            //Variables
            int empHours = 0;
            int empWage = 0;
            int TotalEmpWage = 0;
            //Computation
            for (int day = 0; day < NUM_WORKING_DAYS; day++)
            {
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHours = 4;
                        break;

                    case IS_FULL_TIME:
                        empHours = 8;
                        break;

                    default:
                        empHours = 0;
                        break;
                }
                empWage = empHours * EMP_WAGE_PER_HOUR;
                TotalEmpWage += empWage;
                Console.WriteLine("Emp Wage: " + empWage);

            }
            Console.WriteLine("Total Employee's Wage in 20 days: " + TotalEmpWage);
        }
    }
}
