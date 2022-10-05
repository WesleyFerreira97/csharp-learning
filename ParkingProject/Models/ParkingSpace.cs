using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingProject.Models
{
    internal class ParkingSpace
    {
        public string vehiclePlate;
        public DateTime hourParked;

        public ParkingSpace(string vehiclePlate, DateTime hourParked)
        {
            this.vehiclePlate = vehiclePlate;
            this.hourParked = hourParked;
        }
    }
}
