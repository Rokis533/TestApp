using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileTema
{
    public static class Metodai
    {

        public static int CalculateAge(DateTime birthdate)
        {

            return DateTime.Now.Year - birthdate.Year;
        }
        public static int Sum(int skaicius, int skaicius2)
        {
            return skaicius + skaicius2;
        }
        public static int AskForNumber()
        {
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();
            bool IsValid = int.TryParse(input, out int value);
            if (IsValid)
            {
                return value;
            }
            else
            {
                Console.Write("It's not a number");
            }
            return -1;

        }
        public static bool IsPasswordValid(string password)
        {

            //bool isLonger = password.Length > 8;
            //return isLonger;

            return password.Length > 8;
        }

    }
}
