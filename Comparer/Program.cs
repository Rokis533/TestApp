namespace Comparer
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<Student> students = new List<Student>()
			{
				new Student {
					Id=1,
					Name= "Rokas",
					Year= 1999,
					},
				new Student {
					Id=2,
					Name= "Jonas",
					Year= 2009,
					},
				new Student {
					Id=3,
					Name= "Antanas",
					Year= 1968,
					},
				null,
				null
			};


			Console.WriteLine();
			Console.WriteLine("-----------------------------------");
			Console.WriteLine();

			students.Sort(new StudentComparerById());

			//students.OrderBy(x=>x.Id);

			foreach (Student student in students)
			{
				Console.WriteLine(student.Name);
			}
		}
	}
}