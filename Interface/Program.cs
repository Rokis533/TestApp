namespace Interface
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Dog dog = new Dog();
			Cat cat = new Cat();

			List<IAnimals> list = new List<IAnimals>();
			list.Add(dog);
			list.Add(cat);


			list.ForEach(animal => animal.Talk());

		}

	}

}