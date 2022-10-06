using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingProject.Models
{
    internal class Person
    {
        string name;
        string lastName;

        public Person(string name, string lastName)
        {
            Name = name;
            LastName = lastName;
        }

        string Name
        {
            get => name;
            set
            {
                name = value;
            }
        }
        string LastName
        {
            get => lastName;
            set
            {
                lastName = value;
            }
        }
    }
}
