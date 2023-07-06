using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace c_sharp_enumPractice
{
    /*
    5. Create an enum called TrafficLight to represent the three colors 
    of a traffic light(Red, Yellow, Green). Write a program that simulates
    a traffic light sequence by repeatedly displaying each color for a specified 
    duration.Use a loop to iterate through the enum values and pause the program 
    for a specific duration between each color change.
    */
    internal class Traffic
    {
        public static void trafficEnum()
        {


            int red = ((int)(TrafficLight.RED));//store the value of enum into int
            TrafficLight red1 = ((TrafficLight)(TrafficLight.RED));//to string 

            int yellow = ((int)(TrafficLight.YELLOW));
            TrafficLight yellow1 = ((TrafficLight)(TrafficLight.YELLOW));

            int green = ((int)(TrafficLight.GREEN));
            TrafficLight green1 = ((TrafficLight)(TrafficLight.GREEN));

            while (true)
            {

                for (int i = 0; i < red; i++)
                {
                    Console.WriteLine($"Current color: {red1}");
                    // Pause the program for 1 second
                    Thread.Sleep(1000);
                }
                for (int i = 0; i < yellow; i++)
                {
                    Console.WriteLine($"Current color: {yellow1}");
                    // Pause the program for 1 second
                    Thread.Sleep(1000);
                }
                for (int i = 0; i < green; i++)
                {
                    Console.WriteLine($"Current color: {green1}");
                    // Pause the program for 1 second
                    Thread.Sleep(1000);
                }
                

            }
        }

        


    }
    enum TrafficLight
    {
        RED=10,
        YELLOW=5,
        GREEN=15,
    }
}
