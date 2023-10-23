using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstrakcijos
{
	public abstract class Gyvunas
	{
		public abstract string Vardas { get; set; }
		public int Svoris { get; set; }


		public Gyvunas(int svoris)
		{
			Svoris = svoris;
		}

		public abstract void Kalbek();
		public void ParasykVarda()
		{
			Console.WriteLine($"Mano vardas {Vardas}");
		}

	}
}
