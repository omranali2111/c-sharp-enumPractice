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
            default:
                Console.WriteLine("you have entered invalid input");
                break;


        }


        Console.WriteLine("enter your size");
        string size = Console.ReadLine();
        ClothingSize s = (ClothingSize)Enum.Parse(typeof(ClothingSize), size);//convert from enum type to string 

        switch (s)
        {
            case ClothingSize.SMALL:
                Console.WriteLine("your size is:34-36");
                break;
            case ClothingSize.MEDIUM:
                Console.WriteLine("your size is:38");
                break;
            case ClothingSize.LARGE:
                Console.WriteLine("your size is:40-42");
                break;
            case ClothingSize.EXTRALARGE:
                Console.WriteLine("your size is:44");
                break;
            default:
                Console.WriteLine("you have entered invalid input");
                break;


        }

        Console.WriteLine("enter color");
        string color = Console.ReadLine();
        FavoriteColor c = (FavoriteColor)Enum.Parse(typeof(FavoriteColor), size);

        if (c.Equals(FavoriteColor.YELLOW))
        {
            Console.WriteLine("Confirming the Favorite Color");

        }
        else if(c.Equals(FavoriteColor.GREEN))
        {
            Console.WriteLine("Confirming the Favorite Color");

        }
        else if (c.Equals(FavoriteColor.BLUE))
        {
            Console.WriteLine("Confirming the Favorite Color");

        }
        else if (c.Equals(FavoriteColor.RED))
        {
            Console.WriteLine("Confirming the Favorite Color");

        }
        else { Console.WriteLine("not a valid favorite color"); }

    }
}
       

        
       
       

