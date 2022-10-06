using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingProject.Models
{
    internal class Person
    {
        private string name = string.Empty;
        private string lastName = string.Empty;

        public Person(string name, string lastName)
        {
            Name = name;
            LastName = lastName;
        }

        public string Name
        {
            get => name;
            set
            {
                name = value;
            }
        }
        public string LastName
        {
            get => lastName;
            set
            {
                lastName = value;
            }
        }
    }
}
