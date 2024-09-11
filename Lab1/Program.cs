
Console.Write("Skriv valfri text:");
string userInput = (Console.ReadLine());

double SumOfAllNumbers = 0;

for (int i = 0; i < userInput.Length; i++)
{
    for (int j = i + 1; j < userInput.Length; j++)
    {

        if (!Char.IsDigit(userInput[j]))
        {
            break;
        }

        else if (userInput[i] == userInput[j])
        {
            SumOfAllNumbers += ColorAndCollectNumbers(userInput, i, j);
            break;
        }
    }
}

Console.WriteLine();
Console.WriteLine($"Summan av alla tal är: {SumOfAllNumbers}");




static double ColorAndCollectNumbers(string userInput, int colorStartIndex, int colorEndIndex)
{
    double digitsAsNumber = 0;
    string digitsAsString = string.Empty;
    bool digitIsRed = false;

    for (int digit = 0; digit < userInput.Length; digit++)
    {

        if (digit == colorStartIndex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            digitIsRed = true;
        }

        else if (digit == colorEndIndex + 1)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            digitIsRed = false;
        }

        Console.Write(userInput[digit]);
        if (digitIsRed)
        {
            digitsAsString += userInput[digit];
        }
    }

    Console.ResetColor();
    Console.WriteLine();
    digitsAsNumber = double.Parse(digitsAsString);
    return digitsAsNumber;
}