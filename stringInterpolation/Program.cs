using System;

namespace stringInterpolation
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                var date = DateTime.Now;
                string navn1 = "Kasper";
                string navn2 = "Karsten";
                string navn3 = "Kenneth";
                navn3 = "Susanne";
                Console.WriteLine($"Hello, {navn1}! today is {date.DayOfWeek}, it is {date:HH:mm} now.");
            }


        }
    }
}
