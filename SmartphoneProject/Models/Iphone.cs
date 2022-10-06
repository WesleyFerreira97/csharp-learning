using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartphoneProject.Models
{
    internal class Iphone : Smartphone
    {
        public Iphone(string number, string model, string imei, int memory) 
            : base(number, model, imei, memory)
        {

        }

        public override void InstallApp(string appName)
        {
            Console.WriteLine($"Iphone instalando app: {appName}");
        }
    }
}
