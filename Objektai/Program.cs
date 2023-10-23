namespace Objektai
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            Console.WriteLine("Įveskite vardą");
            string name = Console.ReadLine();

            Console.WriteLine("Įveskite pavardę");
            string lastName = Console.ReadLine();

            people.Add(new Person("Tomas", "No name"));
            people.Add(new Person("Marius", "No name"));
            people.Add(new Person(name, lastName));

            do
            {
                Console.WriteLine("Žalia žolė su uodega bet ne pelė. Kas?");
                string input = Console.ReadLine();
                if (input == "1")
                {
                    people.First(x => x.Name == name).Taškai++;

                }

            } while (true);

            //Console.WriteLine(person.Name);
            //Console.WriteLine(person.LastName);
            //Console.WriteLine(person.Age);
        }
    }
}