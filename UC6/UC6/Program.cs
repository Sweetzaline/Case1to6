using System;

namespace UC6
{
    class Program
    {
        //Constants
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public const int EMP_WAGE_PER_HOUR = 500;
        public const int NUM_WORKING_DAYS = 20;
        public const int MAX_HRS_IN_MONTH = 100;
        static void Main(string[] args)
        {
            Console.WriteLine("Question: Calculate Wages till a condition of total working hours of 100 or max days of 20 is reached for a month");
            //Variables
            int empHours = 0;
            int TotalWorkingDays = 0;
            int TotalEmpHrs = 0;
            //Computation
            while (TotalEmpHrs <= MAX_HRS_IN_MONTH && TotalWorkingDays < NUM_WORKING_DAYS)
            {
                TotalWorkingDays++;
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
                TotalEmpHrs += empHours;
                Console.WriteLine("Day#: " + TotalWorkingDays + " Emp Hrs: " + empHours);
             }
            int TotalEmpWage = TotalEmpHrs * EMP_WAGE_PER_HOUR;
            Console.WriteLine("Total Employee's Wage: " + TotalEmpWage);
        }
    }
}
