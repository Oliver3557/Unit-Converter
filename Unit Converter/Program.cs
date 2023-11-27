using Unit_Converter;

//Declarations
bool keepGoing = true;
int selectedAction = 0;

Length length = new Length();

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
            break;

        case 3:
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