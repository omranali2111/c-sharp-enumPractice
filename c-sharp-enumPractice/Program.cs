using System.Buffers.Text;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Reflection.Metadata;
using System;
using c_sharp_enumPractice;

internal class Program
{


    private static void Main(string[] args)
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


        }


    }
}
       

        
       
       

