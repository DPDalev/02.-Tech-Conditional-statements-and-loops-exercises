using System;

namespace _05.Foreign_languages
{
    class Program
    {
        static void Main()
        {
            /*You can receive only the following combinations:
             English is spoken in England and USA; 
             Spanish is spoken in Spain, Argentina and Mexico; for the others, we should print "unknown"

            */
            var country = Console.ReadLine().ToLower();

            switch (country)
            {
                case "england":
                case "usa":
                    Console.WriteLine("English");
                    break;
                case "spain":
                case "argentina":
                case "mexico":
                    Console.WriteLine("Spanish");
                    break;
                default:
                    Console.WriteLine("unknown");
                    break;
            }


        }
    }
}
