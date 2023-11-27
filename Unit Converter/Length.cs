using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_Converter
{

    internal class Length
    {
        int type = 0;
        float value = 0;

        float mm = 0;
        float cm = 0;
        float inch = 0;
        float foot = 0;
        float yard = 0;
        float mile = 0;
        float km = 0;
        public void GetLength()
        {
            Console.WriteLine("\nPick your Length:\n");
            Console.WriteLine("1. MM 2. CM 3. Inch 4. Foot 5. Yard 6. Mile 7. KM");
            type = int.Parse(Console.ReadLine());
            Console.WriteLine("\nWhat is your value?\n");
            value = float.Parse(Console.ReadLine());

            ConvertLength(type);
        }
        private void ConvertLength(int inputUnit)
        {
            

            switch (inputUnit)
            {
                case 1:
                    mm = value;
                    cm = mm / 10;
                    inch = (float)(mm / 25.4);
                    foot = (float)(mm / 304.8);
                    yard = (float)(mm / 914.4);
                    break;

                case 2:
                    cm = value;
                    mm = cm * 10;
                    inch = (float)(cm / 2.54);
                    foot = (float)(cm / 30.48);
                    yard = (float)(cm / 91.44);
                    mile = (float)(cm / 160900);
                    km = (float)(cm / 100000);
                    break;

                case 3:
                    inch = value;
                    mm = (float)(inch * 25.4);
                    cm = (float)(inch * 2.54);
                    foot = (float)(inch / 12);
                    yard = (float)(inch / 36);
                    mile = (float)(inch / 63360);
                    km = (float)(inch / 39370);
                    break;

                case 4:
                    foot = value;
                    mm = (float)(foot * 304.8);
                    cm = (float)(foot * 30.48);
                    inch = (float)(foot * 12);
                    yard = (float)(foot / 3);
                    mile = (float)(foot / 5280);
                    km = (float)(foot / 3281);
                    break;

                case 5:
                    yard = value;
                    mm = (float)(yard * 914.4);
                    cm = (float)(yard * 91.44);
                    inch = (float)(yard * 36);
                    foot = (float)(yard * 3);
                    mile = (float)(yard * 1760);
                    km = (float)(yard * 1094);
                    break;
                case 6:
                    mile = value;
                    cm = (float)(mile * 160900);
                    inch = (float)(mile * 63360);
                    foot = (float)(mile * 5280);
                    yard = (float)(mile * 1760);
                    km = (float)(mile * 1.609);
                    break;

                case 7:
                    km = value;
                    mm = km * 1000000;
                    cm = km * 100000;
                    inch = (float)(km * 3280.84);
                    foot = (float)(km * 3280.84);
                    yard = (float)(km * 1093.61);
                    mile = (float)(km / 1.609);
                    break;
            }

            Console.WriteLine("\n{0}mm {1}cm {2}inch {3}foot {4}yard {5}mile {6}km", mm, cm, inch, foot, yard, mile, km);
        }
    }
}
