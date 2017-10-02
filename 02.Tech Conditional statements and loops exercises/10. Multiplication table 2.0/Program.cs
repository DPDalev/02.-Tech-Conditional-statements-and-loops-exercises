using System;

namespace _09.Multiplication_table_2_0
{
    class Program
    {
        static void Main()
        {
            var num = int.Parse(Console.ReadLine());
            var multiplier = int.Parse(Console.ReadLine());

            if (multiplier > 10)
                Console.WriteLine($"{num} X {multiplier} = {num * multiplier}");
            else

            for (int i = multiplier; i <= 10; i++)
            {
                Console.WriteLine($"{num} X {i} = {num * i}");
            }
        }
    }
}
