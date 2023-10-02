
using WhileTema;

//string slapt = "159159";
//string input;
//int tries = 1;
//do
//{
//    Console.Write("Enter a password: ");
//    input = Console.ReadLine();
//    if (input != slapt && tries == 2)
//    {
//        Console.WriteLine("Next time you will be blocked ");
//    }
//    if (input != slapt && tries >= 3)
//    {
//        Console.Write("You are blocked ");
//        do
//        {
//            Console.Write("*");
//        }
//        while (true);
//    }
//    tries++;
//}
//while (input != slapt && tries <= 3); //true

//kazka darom
//DateTime dateTime = new DateTime(1995, 1, 1);
//int skaicius = Metodai.AskForNumber();
//if (skaicius == -1)
//{
//    Console.WriteLine("Error");
//}
//int metai = Metodai.Sum(9, 3);

//string input = Console.ReadLine();

//bool IsValid = IsPasswordValid(input);

//Console.WriteLine(IsValid);

//bool IsPasswordValid(string password)
//{
//    return password.Length > 8;
//}
double pinigaiEur = ConvertToEur(15);

double pinigaiBTC = ConvertToBTC(35);

double pinigaiKrona = ConvertToKrona(35);



double ConvertToEur(double money)
{
    return money * 0.85;
}

double ConvertToBTC(double money)
{
    return money * 0.0000009;
}
double ConvertToKrona(double money)
{

    return money * 10;
}

void PrintAll(double money)
{
    double pinigaiEur = ConvertToEur(15);

    double pinigaiBTC = ConvertToBTC(35);

    double pinigaiKrona = ConvertToKrona(35);

    Console.WriteLine($"EUR: {pinigaiEur}, Krona: {pinigaiKrona}, BTC: {pinigaiBTC}");
}















