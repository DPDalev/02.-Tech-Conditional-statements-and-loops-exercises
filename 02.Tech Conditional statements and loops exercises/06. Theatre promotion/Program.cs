using System;

namespace _06.Theatre_promotion
{
    class Program
    {
        public static void Main()
        {
            var typeOfDay = Console.ReadLine().ToLower();
            var age = int.Parse(Console.ReadLine());

            var ticketPriceChildren = 0;
            var ticketPriceAdults = 0;
            var ticketPriceSenior = 0;


            switch (typeOfDay)
            {
                case "weekday":

                    ticketPriceChildren = 12;
                    ticketPriceAdults = 18;
                    ticketPriceSenior = 12;
                    break;

                case "weekend":

                    ticketPriceChildren = 15;
                    ticketPriceAdults = 20;
                    ticketPriceSenior = 15;
                    break;

                case "holiday":

                    ticketPriceChildren = 5;
                    ticketPriceAdults = 12;
                    ticketPriceSenior = 10;
                    break;
            }

                if (age >= 0 && age <= 18)
                   Console.WriteLine("{0}$", ticketPriceChildren);
                else if (age > 18 && age <= 64)
                   Console.WriteLine("{0}$", ticketPriceAdults);
                else if (age > 64 && age <= 122)
                   Console.WriteLine("{0}$", ticketPriceSenior);
                else
                   Console.WriteLine("Error!");
        }
    }
}
