using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_enumPractice
{
    /*
    3. Create an enum called FavoriteColor to represent different
    favorite colors(Red, Blue, Green, etc.). Write a program that 
    asks the user to enter their favorite color.If the entered color
    is one of the enum values, display a message confirming their
    choice.If the entered color is not in the enum, display a message 
    stating that it is not a valid favorite color.
    */
    
    internal class Color
    {
        public static void favColor()
        {
            Console.WriteLine("enter color");
            string color = Console.ReadLine();
            FavoriteColor c = (FavoriteColor)Enum.Parse(typeof(FavoriteColor), color);

            if (c.Equals(FavoriteColor.YELLOW))
            {
                Console.WriteLine("Confirming the Favorite Color");

            }
            else if (c.Equals(FavoriteColor.GREEN))
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

    enum FavoriteColor
    {
        RED,
        GREEN,
        BLUE,
        YELLOW,
    }
}
