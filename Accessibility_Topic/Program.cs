namespace Accessibility_Topic
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Person person = new Person("Rokas", "Slaboševičius", 1999, "2314568486");

			Console.WriteLine(person.GetUserData());
		}
	}
}