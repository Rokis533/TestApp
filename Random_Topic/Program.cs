namespace Random_Topic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            //                           1 iki 10
            int randomNumber = rand.Next(1, 91);
            int randomNumbe3 = rand.Next(1, 91);

            var randomNumber2 = rand.NextDouble(); // nuo 0.00 iki 1.00

            for (int i = 0; i < 10; i++)
            {
                int randomNumberNext = rand.Next(-55, 101);
                Console.WriteLine($"Atsitiktinai sugeneruotas skaičius yra {randomNumberNext}");
            }
            int[,] matrix = new int[randomNumber, randomNumbe3];
        }
    }
}