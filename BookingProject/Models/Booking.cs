using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookingProject.Models;

namespace BookingProject.Models
{
    internal class Booking
    {
        List<Person> people = new List<Person>();
        Suite suite = new Suite();
        int daysReserved;

        public Booking(List<Person> people, Suite suite, int daysReserved)
        {
            this.people = people;
            this.suite = suite;
            this.daysReserved = daysReserved;
        }
    }
}
