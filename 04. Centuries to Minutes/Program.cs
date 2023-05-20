using System;

namespace _04._Centuries_to_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            //int century = int.Parse(Console.ReadLine());
            //Console.WriteLine($"{century} centuries = {century*100} years = {(int)(century * 100 * 365.2422)} days = " +
            //    $"{(int)(century * 100 * 365.2422 * 24)} hours = {(int)(century * 100 * 365.2422 * 24 * 60)} minutes");
            int centuries = int.Parse(Console.ReadLine());
            int years = centuries * 100;
            int days = (int)(years * 365.2422);
            int hours = days * 24;
            int minutes = hours * 60;

            Console.WriteLine("{0} centuries = {1} years = {2} days = {3} hours = {4} minutes", centuries, years, days, hours, minutes);
        }
    }
}

