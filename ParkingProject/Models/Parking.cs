using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingProject.Models
{
    internal class Parking
    {
        private decimal _initialPrice;
        private decimal _pricePerHour;
        //List<ParkingSpace> listVehicles = new List<ParkingSpace>();

        public Parking(decimal initialPrice, decimal pricePerHour)
        {
            InitialPrice = initialPrice;
            PricePerHour = pricePerHour;
        }

        public decimal InitialPrice
        {
            get => _initialPrice;
            set
            {
                _initialPrice = value;
            }
        }
        public decimal PricePerHour
        {
            get => _initialPrice;
            set
            {
                _initialPrice = value;
            }
        }

        public void AddVehicle(string vehiclePlate)
        {
            Console.WriteLine("Add Vehicle");
        }
    }
}
