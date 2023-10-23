using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Accessibility_Topic
{
	internal class Anim : Person
	{
		public Anim(string name, string lastName, int years, string id) : base(name, lastName, years, id)
		{
			ID = id;
		}
	}
	internal class Person : Human
	{
		private int Years { get; set; }
		private string Name { get; set; }
		private string LastName { get; set; }
		public Person(string name, string lastName, int years, string id)
		{
			Years = years;
			Name = name;
			LastName = lastName;
			ID = id;
		}
		private string GetInitials()
		{
			return Name[0] + "" + LastName[0];
		}
		public string GetUserData()
		{
			string initial = GetInitials();
			return $"{Name} {LastName}___{initial}_{ID}";

		}

		public void SetName(string name)
		{
			Name = name;
		}
		public void SetYears(int years)
		{
			Years = years;
		}
		public int GetYears()
		{
			return Years;
		}
	}
}
