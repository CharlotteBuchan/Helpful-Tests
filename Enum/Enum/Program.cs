using System;

namespace MyApp
{
    internal class Program
    {
        enum Months
        {
            January,
            February,
            March,
            April,
            May,
            June,
            July,
            August,
            September,
            October,
            November,
            December
        }

        enum DaysoftheWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        enum Seasons
        {
           Spring, 
           Summer, 
           Autumn, 
           Winter
        }

        enum Planets
        {
            Mercury,
            Venus,
            Earth,
            Mars,
            Jupiter,
            Saturn,
            Uranus,
            Neptune
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Seasons.Winter);
            Console.WriteLine((DaysoftheWeek)1);
            Console.WriteLine(Months.July);
            Console.WriteLine($"The 5th closest planet to the sun is {(Planets)4}");
            Console.WriteLine("Every planet: ");
            foreach (string str in Enum.GetNames(typeof(Planets)))
                Console.WriteLine(str);
        }
    }
}