using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your birthday, formatted dd/mm/yyyy: ");
            DateTime Birthday = DateTime.Parse(Console.ReadLine());
            int BirthdayYear = (Birthday.Year);
            int BirthdayMonth = (Birthday.Month);
            int BirthdayDay = (Birthday.Day);
            DateTime Today = DateTime.Today;
            int TodayYear = (Today.Year);
            int TodayMonth = (Today.Month);
            int TodayDay = (Today.Day);
            int YearDifference = TodayYear - BirthdayYear;
            if (BirthdayMonth >= TodayMonth)
            {
                if (BirthdayDay > TodayDay)
                {
                    YearDifference = YearDifference - 1;
                }
            }
            if (YearDifference < 18)
            {
                Console.WriteLine("You are not old enough to vote.");
            }
            else
            {
                Console.WriteLine("You can vote.");
            }
            

        }
    }
}