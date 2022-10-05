using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estacionamento.Models
{
    internal class Parking
    {
        private decimal _initialPrice;
        private decimal _pricePerHour;

        public Parking(decimal initialPrice, decimal pricePerHour)
        {
            InitialPrice = initialPrice;
            PricePerHour = pricePerHour;
        }

        public decimal InitialPrice { 
            get => _initialPrice; 
            set { 
                _initialPrice = value; 
            } 
        }
        public decimal PricePerHour { 
            get => _initialPrice; 
            set { 
                _initialPrice = value; 
            } 
        }
    }
}
