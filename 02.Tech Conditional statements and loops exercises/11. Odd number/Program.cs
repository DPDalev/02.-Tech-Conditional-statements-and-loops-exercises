using System;

namespace _11.Odd_number
{
    class Program
    {
        public static void Main()
        {
            var oddEven = int.Parse(Console.ReadLine());

            while (oddEven % 2 == 0)
            {
                Console.WriteLine("Please write an odd number.");

                oddEven = int.Parse(Console.ReadLine());
            }
            
            Console.WriteLine($"The number is: {Math.Abs(oddEven)}");

        }
    }
}
