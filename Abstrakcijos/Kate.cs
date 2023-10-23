using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstrakcijos
{
	internal class Kate : Gyvunas
	{
		public override string Vardas { get; set; }
		public Kate(string vardas, int svoris) : base(svoris)
		{
			Vardas = vardas;
		}
		public override void Kalbek()
		{
			Console.WriteLine("Miau");
		}
	}
}
