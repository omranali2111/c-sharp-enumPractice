using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_enumPractice
{
    /*
  1. Create an enum called DaysOfWeek to represent the days of 
  the week(Sunday, Monday, Tuesday, etc.). Write a program that 
  prompts the user to enter a day of the week and displays a message
  based on the entered value.Use the switch statement to handle different cases.
  */
    internal class Day
    {

        public static void weekDays()
        {
            Console.WriteLine("enter a day:");
            string day = Console.ReadLine();
            DayOfWeek d = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), day);//convert from enum type to string 

            switch (d)
            {
                case DayOfWeek.Sunday:
                    Console.WriteLine("the first day of the week");
                    break;
                case DayOfWeek.Monday:
                    Console.WriteLine("the second day of the week");
                    break;
                case DayOfWeek.Tuesday:
                    Console.WriteLine("the third day of the week");
                    break;
                case DayOfWeek.Wednesday:
                    Console.WriteLine("the fourth day of the week");
                    break;
                case DayOfWeek.Thursday:
                    Console.WriteLine("the fifth day of the week");
                    break;
                case DayOfWeek.Friday:
                    Console.WriteLine("the sixth day of the week");
                    break;
                case DayOfWeek.Saturday:
                    Console.WriteLine("the seventh day of the week");
                    break;
                default:
                    Console.WriteLine("you have entered invalid input");
                    break;
            }



        }
    }
    

    enum DaysOfWeek
    {
        SUNDAY,
        MONDAY,
        TUESDAY,
        WEDNESDAY,
        THURSDAY,
        FRIDAY,
        SATURDAY,


    }
}
