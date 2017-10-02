using System;

namespace _12.Number_checker
{
    class Program
    {
        static void Main()
        {
            var num = 0.0;

            try
            {
                num = double.Parse(Console.ReadLine());
                Console.WriteLine("It is a number.");
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input!");
            }
        }
    }
}
