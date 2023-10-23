using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstrakcijos
{
	internal class Suo : Gyvunas
	{
		private string vardas { get; set; }

		public override string Vardas
		{
			get { return vardas; }
			set
			{
				if (!string.IsNullOrEmpty(value))
				{
					vardas = value;
				}
				else
				{
					Console.WriteLine("Vardas turi turėti reikšme!!!!");
				}
			}
		}

		public bool ArDarbinis { get; set; }
		public Suo(string vardas, int svoris) : base(svoris)
		{
			Vardas = vardas;
		}
		public override void Kalbek()
		{
			Console.WriteLine("Woof");
		}
	}
}
