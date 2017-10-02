using System;

namespace _03.After_30_minutes
{
    class Program
    {
        static void Main(string[] args)
        {
        var hours = int.Parse(Console.ReadLine());
        var mins = int.Parse(Console.ReadLine());


            mins += 30;

        if (mins > 59)
        {
            mins -= 60;
            hours += 1;
                if (hours > 23)
                    hours = 0;
        }

        Console.WriteLine("{0}:{1:d2}", hours, mins);


        
        }
    }
}