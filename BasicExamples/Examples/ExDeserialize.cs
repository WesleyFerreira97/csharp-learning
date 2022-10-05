using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BasicExamples.Examples
{
    internal class ExDeserialize
    {
        public int Id { get; set; }
        
        // Converte uma possivel entrada fora do formato para outro identificador
        // na convenção de nomeclatura do C#
        [JsonProperty("Nome_Produto")]
        public string Product { get; set; }
        public decimal Price { get; set; }
        public DateTime DateSale { get; set; }
    }
}
