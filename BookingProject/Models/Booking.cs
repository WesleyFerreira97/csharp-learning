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
        Suite suite { get; set; }
        int daysReserved;

        public Booking(Suite pickSuite, int daysReserved)
        {
            this.suite = pickSuite;
            this.daysReserved = daysReserved;
        }

        public void ChangeSuite(Suite newSuite)
        {
            suite = newSuite;
        }

        public void AddGuests(List<Person> allGuests)
        {
            if(allGuests.Count <= suite.Capacity)
            {
                people = allGuests;
                Console.WriteLine("Hospedes adicionados!");
            } else
            {
                Console.WriteLine("Quantidade de hospedes acima do permitido!");
            }
        }
        public int numberOfGuests()
        {
            return daysReserved;
        }
        
        public decimal AmountToBePaid()
        {
            decimal currentDailyPrice = suite.DailyPrice;
            decimal total = currentDailyPrice * daysReserved;
            Console.WriteLine($"Valor total: R${total}");

            if (daysReserved >= 10)
            {
                decimal totalDiscount = (total * 10) / 100;
                
                Console.WriteLine($"Desconto adicionado: -R${totalDiscount}");
                Console.WriteLine($"Valor Final: R${total - totalDiscount}");
                return total - totalDiscount;
            }

            return total;
        }
    }
}
