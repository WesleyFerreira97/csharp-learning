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
        private decimal initialPrice;
        private decimal pricePerHour;
        List<ParkingSpace> listVehicles = new List<ParkingSpace>();

        public Parking(decimal initialPrice, decimal pricePerHour)
        {
            InitialPrice = initialPrice;
            PricePerHour = pricePerHour;
        }

        public decimal InitialPrice
        {
            get => initialPrice;
            set
            {
                initialPrice = value;
            }
        }
        public decimal PricePerHour
        {
            get => pricePerHour;
            set
            {
                pricePerHour = value;
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
                DateTime currentTime = DateTime.Now;
                ParkingSpace newVehicle = new ParkingSpace(vehiclePlate, currentTime);
                listVehicles.Add(newVehicle);

                Console.WriteLine("Veículo Adicionado!");
            } else
            {
                Console.WriteLine("Por favor, insira uma placa no padrão correto!");
            }
        }

        public void RemoveVehicle(int vehicleNumber)
        {
            ParkingSpace selectedVehicle = listVehicles.ElementAt(vehicleNumber);
            DateTime initialHourParked = selectedVehicle.hourParked;
            DateTime currentTime = DateTime.Now;

            // Math abs - Retorna o valor absoluto evitando valores negativos
            double pastHours = Math.Abs((initialHourParked - currentTime).TotalSeconds);

            // Calcula a cada 10 segundos uma cobrança
            int times = (int)pastHours / 10;
            decimal total = initialPrice + (times * pricePerHour);
            Console.WriteLine($"Valor a pagar : R${total}");

            try
            {
                listVehicles.RemoveAt(vehicleNumber);
            }
            catch (Exception err)
            {
                Console.WriteLine(err);

            }
        }

        public void GetAllVehicles()
        {
            for(int i = 0; i < listVehicles.Count; i++)
            {
                Console.WriteLine($"{i}: {listVehicles[i].vehiclePlate}");
            }
        }
    }
}
