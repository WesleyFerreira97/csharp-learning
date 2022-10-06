using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingProject.Models
{
    internal class Suite
    {
        string suiteType = "Basic";
        int capacity = 1;
        decimal dailyPrice = 20.50M;

        public Suite(string suiteType, int capacity, decimal dailyPrice)
        {
            SuiteType = suiteType;
            Capacity = capacity;
            DailyPrice = dailyPrice;
        }

        public string SuiteType { 
            get => suiteType; 
            set
            {
                suiteType = value;
            } 
        }
        public int Capacity { 
            get => capacity; 
            set
            {
                capacity = value;
            } 
        }
        public decimal DailyPrice { 
            get => dailyPrice; 
            set
            {
                dailyPrice = value;
            } 
        }


    }
}
