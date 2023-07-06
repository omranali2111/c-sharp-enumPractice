using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
namespace c_sharp_enumPractice
{
    /*
    2. Create an enum called ClothingSize to represent different clothing
    sizes(Small, Medium, Large, etc.). Write a program that prompts the user
    to enter their clothing size and displays a message based on the entered 
    value.Use an if-else statement to handle different cases.
    */
    internal class Clothing
    {
        public static void colthSizing()
        {
            Console.WriteLine("enter your size");
            string size = Console.ReadLine();
            ClothingSize s = (ClothingSize)Enum.Parse(typeof(ClothingSize), size.ToUpper());//convert from enum type to string 
            //ToUpper() convert the input to upper case
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
        }
    }

    enum ClothingSize
    {
        SMALL,
        MEDIUM,
        LARGE,
        EXTRALARGE,


    }


}
