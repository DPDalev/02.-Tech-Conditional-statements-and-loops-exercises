using System;

namespace _04.Month_printer
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());

            string[] month = {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            
            if (num > 12 || num < 1)
                Console.WriteLine("Error!");
            else
                Console.WriteLine(month[num-1]);
        }
    }
}
