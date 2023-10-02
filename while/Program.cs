int userNumber;
bool isValid;

do
{
    Console.Write("Enter a number between 1 and 10: ");
    string input = Console.ReadLine();

    isValid = int.TryParse(input, out userNumber);

    if (isValid && userNumber >= 1 && userNumber <= 10)
    {
        Console.WriteLine("You entered a valid number: " + userNumber);
    }
    else
    {
        Console.WriteLine("Invalid input. Please try again.");
    }
} while (!isValid || userNumber < 1 || userNumber > 10);
