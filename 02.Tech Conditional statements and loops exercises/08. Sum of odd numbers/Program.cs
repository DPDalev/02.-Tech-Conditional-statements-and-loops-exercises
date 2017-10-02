using System;

namespace _08.Sum_of_odd_numbers
{
    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var sum = 0;
            var currNum = 1;

            for (var i = 1; i <= n; i++)
            {
                Console.WriteLine(currNum);
                sum += currNum;
                currNum += 2;

            }
            Console.WriteLine("Sum: " + sum);


        }
    }
}
