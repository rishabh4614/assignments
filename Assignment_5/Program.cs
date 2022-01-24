using System;

namespace Assignment_5
{

   //Write a program in C# to Display temperature in Celsius. Accept the temperature in Fahrenheit




    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the Temperature in Fahrenheit : ");
            double temp = Convert.ToInt32(Console.ReadLine());
            double cel = (temp - 32)* 5 / 9;
            Console.WriteLine("Temperatur in Celcius is : " + cel);
        }
    }
}
