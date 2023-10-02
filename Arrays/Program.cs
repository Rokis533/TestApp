Console.WriteLine("Pradžia");
Console.WriteLine("---------------------------------------------");
Console.WriteLine();

Console.WriteLine("Kiek turite vaikų?");

int[] ints = { 1, 5, 3, 4 };


int vaikuKiekis = Convert.ToInt32(Console.ReadLine());

string[] vaikuVardai = new string[vaikuKiekis];

for (int i = 0; i < vaikuVardai.Length; i++)
{
    Console.WriteLine($"Įveskite {i + 1} vaiko vardą:");
    vaikuVardai[i] = Console.ReadLine();
}


Console.WriteLine();
Console.WriteLine("Jūsų vaikų vardai:");
foreach (var vaikas in vaikuVardai)
{
    Console.WriteLine(vaikas);
}
























//string[] pasisveikinimai = new string[3];



//string[] daliuPavadinimai = { "ratai", "kebulas", "vairas" };

//string[] daliuPavadinimaiNaujas = new string[3];

//daliuPavadinimaiNaujas[0] = "ratai";
//daliuPavadinimaiNaujas[1] = "kebulas";
//daliuPavadinimaiNaujas[2] = "vairas";


//int[] kainos = { 400, 1500, 50 };

//string input = Console.ReadLine();
//int index = Array.IndexOf(daliuPavadinimai, input);
//if (index == -1)
//{
//    Console.WriteLine("Nerasta");
//}
//else
//{
//    Console.WriteLine($"Rastas {daliuPavadinimai[index]} - {kainos[index]}$, jo vieta {index}");
//}

//for (int i = 0; i < pasisveikinimai.Length; i++)
//{
//    Console.WriteLine("Įveskite pasisveikinimą kita kalba");
//    pasisveikinimai[i] = Console.ReadLine();
//}

Console.WriteLine("-------------------------------");
//for (int i = 0; i < daliuPavadinimai.Length; i++)
//{
//    Console.WriteLine(daliuPavadinimai[i] + " - " + kainos[i]);
//}
//foreach (string dalis in daliuPavadinimai)
//{
//    Console.WriteLine(dalis);
//}




































//// Sukuriame masyvą, kuris gali saugoti 5 sveikus skaičius
//int[] skaiciai = new int[5];

//// Užpildome masyvą skaičiais
//skaiciai[0] = 10;
//skaiciai[1] = 20;
//skaiciai[2] = 30;
//skaiciai[3] = 40;
//skaiciai[4] = 50;

//// Atspausdiname masyvo elementus
//Console.WriteLine("Masyvo elementai:");

//for (int i = 0; i < skaiciai.Length; i++)
//{
//    Console.WriteLine("Elementas {0}: {1}", i, skaiciai[i]);
//}

//// Arba galime naudoti foreach ciklą, kad atspausdintume elementus
//Console.WriteLine("\nMasyvo elementai naudojant foreach:");

//foreach (int skaicius in skaiciai)
//{
//    Console.WriteLine(skaicius);
//}


//string[] zodziuMasyvas = new string[] { "Labas", "rytas", "pasauli" };

//// Atspausdiname visus žodžius masyve
//foreach (string zodis in zodziuMasyvas)
//{
//    Console.WriteLine(zodis);
//}