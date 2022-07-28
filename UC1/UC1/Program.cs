using System;

namespace UC1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Constants
            int IS_WORKING = 1;
            Random random = new Random();

            //Computation
            int empCheck = random.Next(0, 2);
            if (empCheck == IS_WORKING)
            {
                Console.WriteLine("Employee is Present.");
            }
            else
            {
                Console.WriteLine("Employee is Absent!");
            }
        }
    }
}
