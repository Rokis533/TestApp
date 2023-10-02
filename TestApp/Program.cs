//using System.Text.RegularExpressions;

//string ivestis = Console.ReadLine();
//if (int.TryParse(ivestis, out int resultInteger))
//{
//    Console.WriteLine(resultInteger);
//}
//else
//{
//}






//string resultString = Regex.Match(ivestis, @"\d+").Value;
//Console.WriteLine(int.Parse(resultInteger));

//"15 diena" 


//int score = 15;
//score switch
//{
//    < 50 => "F",
//    < 60 => "E",
//    < 70 => "D",
//    < 80 => "C",
//    < 90 => "B",
//    _ => "A",
//};
//void   
//Console.WriteLine(grade);

//int score = 45;
//int minScore = 30;
//string grade;

//switch (score)
//{
//    case int s when s < 50 && s >45:
//        grade = "F";
//        break;
//    case int s when s < 60:
//        grade = "E";
//        break;
//    case int s when s < 70:
//        grade = "D";
//        break;
//    case int s when s < 80:
//        grade = "C";
//        break;
//    case int s when s < 90:
//        grade = "B";
//        break;
//    default:
//        grade = "A";
//        break;
//}

//if (score < 50)
//{
//    grade = "F";
//}
//else if (score < 60 && score > 50)
//{
//    grade = "E";
//}
//else
//{
//    grade = "A";
//}

//switch (score)
//{
//    case < 50:
//        grade = "F";
//        break;
//    case < 60:
//        grade = "E";
//        break;
//    case < 70:
//        grade = "D";
//        break;
//    case < 80:
//        grade = "C";
//        break;
//    case < 90:
//        grade = "B";
//        break;
//    default:
//        grade = "A";
//        break;
//}

//Console.WriteLine(grade);

//int pirmas;
//if (true)
//{
//    pirmas = 0;
//    int antras = 0;
//}

//Console.Write(pirmas);


//Console.Write("Enter a day of the week: ");
//string day = Console.ReadLine();
//string dayType;

//switch (day.ToLower())
//{
//    case "monday":
//    case "tuesday":
//    case "wednesday":
//    case "thursday":
//    case "friday":
//        dayType = "Weekday";
//        break;
//    case "saturday":
//    case "sunday":
//        dayType = "Weekend";
//        break;
//    default:
//        dayType = "Invalid day";
//        break;
//}

//switch (dayType)
//{
//    case "Weekday":
//        Console.WriteLine("The entered day is a " + dayType + ".");
//        break;
//    case "Weekend":
//        //kitas veiksmas
//        break;
//}
//Console.WriteLine("The entered day is a " + dayType + ".");
string tipas = "staciakampis";
string krastine;
switch (tipas)
{
    case "staciakampis":
        Console.Write("Ivesk kraštinę:");
        krastine = Console.ReadLine();

        break;
    case "kvadratas":
        Console.Write("Ivesk kraštinę:");
        krastine = Console.ReadLine();

        break;
};
if (tipas == "staciakampis")
{

}
