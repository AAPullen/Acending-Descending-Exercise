string answer = "y";

do
{
    Console.Write("Enter a number: ");
    int userNumber = int.Parse(Console.ReadLine());
    for (int userNumberDecending = userNumber; userNumberDecending > -1; userNumberDecending--)
    {
        Console.Write(userNumberDecending + " ");
    }
    Console.WriteLine();
    for (int zero = 0; zero < userNumber + 1; zero++)
    {
        Console.Write(zero + " ");
    }
    Console.WriteLine("\nWould you like to continue (y/n)?");
    answer = Console.ReadLine().ToLower();
} while (answer == "y");

Console.WriteLine("\nGoodbye!");