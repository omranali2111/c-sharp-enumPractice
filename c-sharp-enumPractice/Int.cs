using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
namespace c_sharp_enumPractice
{
    /*
    4. Write a program that converts an integer input to its corresponding
    enum value. Prompt the user to enter an integer and display the corresponding 
    enum value. Handle cases where the entered integer does not match any enum 
    value by displaying an appropriate error message.
   */
    internal class Int
    {
        public static void inte()
        {
            Console.WriteLine("enter number");
            int ordinalValue = int.Parse(Console.ReadLine());
            integer type = (integer)ordinalValue;//convert from the value of enum to string of enum
                                                 // Console.WriteLine(type);

            if (type == integer.ONE|| type == integer.TWO|| type == integer.THREE|| type == integer.FOUR|| type == integer.FIVE|| type == integer.SIX|| type == integer.SEVEN)
            {
                Console.WriteLine(type.ToString());
            }

            else
            {
                Console.WriteLine("invalid input");
            }
        }
        

    }

    enum integer
    {
        ONE=7,
        TWO=6,
        THREE=5,
        FOUR=4,
        FIVE=3,
        SIX=2, 
        SEVEN=1,

    }

}
