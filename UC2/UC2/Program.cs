using System;

namespace UC2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Question: Calculate Daily Employee Wage");
            //Constants
            int PRESENT = 1;
            int EMP_WAGE_PER_HOUR = 500;
            //variables
            int empHr = 0;
            int empWage = 0;
            Random random = new Random();
            //Computation
            int empCheck = random.Next(0, 2);
            if (empCheck == PRESENT)
            {
                empHr = 8;
                Console.WriteLine("Employee is Present Today. ");            }
            else
            {
                empHr = 0;
                Console.WriteLine("Employee is Absent Today. ");
            }
            empWage = empHr * EMP_WAGE_PER_HOUR;
            Console.WriteLine("Employee's Daily Wage is : " + empWage);
        }
    }
}
