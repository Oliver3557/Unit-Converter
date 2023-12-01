using Unit_Converter;

//Declarations
bool keepGoing = true;
int selectedAction = 0;

//Setup class references
Length length = new Length();
Temperature temp = new Temperature();
Weight weight = new Weight();

Console.WriteLine("Welcome to the Unit Converter!");
Console.WriteLine("\nWhat do you need converting?");
Console.WriteLine("1. Length\n2. Temperature\n3. Weight\n4. Time\n5. Exit");

selectedAction = int.Parse(Console.ReadLine());

while(keepGoing)
{
    switch (selectedAction)
    {
        case 1:
            length.GetLength();
            break;

        case 2:
            temp.GetTemp();
            break;

        case 3:
            weight.getWeight();
            break;

        case 4:
            break;

        case 5:
            keepGoing = false;
            break;

        default: 
            Console.WriteLine("Invalid input");
            break;
    }
}