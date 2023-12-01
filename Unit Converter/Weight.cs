using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_Converter
{
    internal class Weight
    {
        int type = 0;
        float value = 0;

        float grams = 0;
        float kg = 0;
        float pounds = 0;

        public void getWeight()
        {
            Console.WriteLine("\nPick your Weight type:\n1. Grams 2. Kilograms 3. Pounds");
            type = int.Parse(Console.ReadLine());
            Console.WriteLine("\nWhat is your value?\n");
            value = float.Parse(Console.ReadLine());

            ConvertWeight(type);
        }
        private void ConvertWeight(int inputWeight)
        {
            switch (type)
            {
                case 1:
                    grams = value;
                    kg = grams / 1000;
                    pounds = (float)(grams / 453.592);
                    break;

                case 2:
                    kg = value;
                    grams = kg * 1000;
                    pounds = (float)(kg * 2.20462);
                    break;

                case 3:
                    pounds = value;
                    grams = (float)(pounds * 453.592);
                    kg = (float)(pounds / 2.20462);
                    break;

                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }
            Console.WriteLine("\nGrams: {0}\nKilograms: {1}\nPounds: {2}\n", grams, kg, pounds);
        }
    }
}
