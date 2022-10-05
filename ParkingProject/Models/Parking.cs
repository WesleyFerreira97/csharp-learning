using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ParkingProject.Models
{
    internal class Parking
    {
        private decimal _initialPrice;
        private decimal _pricePerHour;
        List<ParkingSpace> listVehicles = new List<ParkingSpace>();

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
            string plateSanitize = vehiclePlate.Replace("-", "").Trim();

            Regex normalPattern = new Regex("[a-zA-Z]{3}[0-9]{4}");
            Regex patternMercosul = new Regex("[a-zA-Z]{3}[0-9]{1}[a-zA-Z]{1}[0-9]{2}");

            if( normalPattern.IsMatch(plateSanitize) |
                patternMercosul.IsMatch(plateSanitize)
                )
            {
                Console.WriteLine("Esta dentro do padrão");
            }
            //if (vehiclePlate.Length > 3 && vehiclePlate.Length < 10)
            //{
            //    DateTime currentTime = DateTime.Now;
            //    ParkingSpace newVehicle = new ParkingSpace(vehiclePlate, currentTime);
            //    listVehicles.Add(newVehicle);
            //    Console.WriteLine("Added Vehicle");

            //} else
            //{
            //    Console.WriteLine("Placa adicionada inválida");
            //}
        }

        public void GetAllVehicles()
        {
            foreach(var vehicle in listVehicles)
            {
                Console.WriteLine($"Placa do veículo : {vehicle.vehiclePlate}");
                Console.WriteLine($"Hora estacionado : {vehicle.hourParked}");
            }
        }
    }
}
