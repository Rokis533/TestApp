using Microsoft.VisualBasic;

namespace ExceptionHandeling
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int year = 10;
			try
			{
				ValidateAge(year);

				year = -10;

			}
			catch (InvalidAgeException ex)
			{
				Console.BackgroundColor = ConsoleColor.Red;
				Console.WriteLine("Exception: " + ex.Message);
				Console.ResetColor();
			}


		}
		static void ValidateAge(int age)
		{
			if (age < 0)
			{
				throw new InvalidAgeException($"{DateTime.Now} įvyko klaida ValidateAge metode age={age}");
			}
		}
	}
}