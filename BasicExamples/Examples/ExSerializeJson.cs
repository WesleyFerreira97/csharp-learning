using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExamples.Examples
{
    internal class ExSerializeJson
    {
        public int Id { get; set; }
        public string Product { get; set; }
        public decimal Price { get; set; }

        public ExSerializeJson(int id, string product, decimal price)
        {
            Id = id;
            Product = product;
            Price = price;
        }
    }
}
