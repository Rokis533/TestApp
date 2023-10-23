namespace Abstrakcijos
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var suo1 = new Suo("Lubix", 15);
			var suo2 = new Suo("REX", 15);
			suo2.ArDarbinis = true;

			if (suo2.ArDarbinis)
			{
				Console.WriteLine("Gaudyk");
			}





			//var suo3 = new Suo("CIUC", 15);
			//var kate1 = new Kate("Rainė", 30);
			//var kate2 = new Kate("Kiuss", 30);
			//var kate3 = new Kate("Mur", 30);
			//List<Gyvunas> gyvunai = new List<Gyvunas>();
			//gyvunai.Add(suo1);
			//gyvunai.Add(suo2);
			//gyvunai.Add(suo3);
			//gyvunai.Add(kate1);
			//gyvunai.Add(kate2);
			//gyvunai.Add(kate3);

			//foreach (var gyvunas in gyvunai)
			//{
			//	gyvunas.ParasykVarda();
			//	if (gyvunas is Suo)
			//	{
			//		var su = gyvunas as Suo;
			//		if (su.ArDarbinis)
			//		{
			//			Console.WriteLine("Gaudyk");
			//		}
			//		Console.WriteLine("Sedet!");
			//	}

			//	gyvunas.Kalbek();
			//	Console.WriteLine("----------------------------------");
			//}
		}



	}
}