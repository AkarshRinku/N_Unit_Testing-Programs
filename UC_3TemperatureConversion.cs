using System;
using System.Collections.Generic;
using System.Text;

namespace N_Unit_Testing
{
    class UC_3TemperatureConversion
    {
        public void Tempconv()
        {
            Console.WriteLine("Welcome to Temperature Conversion");

            double Celsius;
            double Farenheit;

            Console.WriteLine("Enter the option ");

            int temperature = Convert.ToInt32(Console.ReadLine());
            switch (temperature)
            {
                case 1:
                    Console.WriteLine("enter the temperature ");

                    Farenheit = Convert.ToInt32(Console.ReadLine());
                    Celsius = (Farenheit * 9 / 5) + 32;
                    Console.WriteLine("the celsius :  " + Celsius);
                    break;
                case 2:
                    Console.WriteLine("enter the temperature");

                    Celsius = Convert.ToInt32(Console.ReadLine());
                    Farenheit = (Celsius - 32) * 5 / 9;
                    Console.WriteLine("the farhenheit : " + Farenheit);
                    break;
            }
        }
    }
    }

