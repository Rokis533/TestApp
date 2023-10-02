public class Program
{
    static void Main(string[] args)
    {
        string vardas = Console.ReadLine();
        string pavarde = Console.ReadLine();

        if(GetInitials(vardas, pavarde, out string initials))
        {
            Console.WriteLine(initials);
        }
        else { 
            Console.WriteLine("Nepavyko");
        }

    }

    public static bool GetInitials(string vardas, string pavarde, out string initials)
    {
        if(vardas.Trim().Length > 0 && pavarde.Trim().Length > 0)
        {
              initials = vardas[0] + "" + pavarde[0] ;
              return true;
        }
        else
        {
            initials = null;
            return false;
        }
    }


    //Arange |
    // name = Rokas
    // expectedName = Ponas Rokas

    //Act 
    //KeistiVarda(ref name);

    //Assert
    // (name, expectedName)





    public static void KeistiVarda(ref string name)
    {
        name = "Ponas " + name;
    }
    public static void KeistiSkaiciu(ref int skaicius, ref int skaicius2)
    {
        skaicius = 20;

        skaicius2 = 0;
    }
    public static void KeistiSkaiciuKitaip(ref int skaicius)
    {
        skaicius = 20;
    }
}