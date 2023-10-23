using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objektai
{
    public class Person
    {
        public Person(string name, string lastName)
        {
            Name = name;
            LastName = lastName;
        }
        public string Name { get; private set; }
        public string LastName { get; private set; }
        public int Taškai { get; set; }

    }
}
