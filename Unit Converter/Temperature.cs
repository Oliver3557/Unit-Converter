using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_Converter
{
    internal class Temperature
    {
        int type = 0;
        float value = 0;
        float celcius = 0;
        float fahrenheit = 0;
        public void GetTemp()
        {
            Console.WriteLine("\nPick your Temperature type:\n1. Celcius 2. Fahrenheit");
            type = int.Parse(Console.ReadLine());
            Console.WriteLine("\nWhat is your value?\n");
            value = float.Parse(Console.ReadLine());

            ConvertTemp(type);
        }
        private void ConvertTemp(int inputUnit)
        {
            switch(inputUnit)
            { 
                case 1:
                    celcius = (float)value;
                    fahrenheit = (celcius * 9) / 5 + 32;
                    break;

                case 2:
                    fahrenheit = (float)value;
                    celcius = (fahrenheit - 32) * 5 / 9;
                    break;

                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }
            Console.WriteLine("\nCelcius: {0}\nFahrenheit: {1}\n", celcius, fahrenheit);
        }
    }
}
