using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartphoneProject.Models
{
    internal class Nokia : Smartphone
    {
        public Nokia(string number, string model, string imei, int memory) 
            : base(number, model, imei, memory)
        {

        }

        public override void InstallApp(string appName)
        {
            Console.WriteLine($"Nokia instalando app: {appName}");
        }
    }
}
