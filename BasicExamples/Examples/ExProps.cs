using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// https://www.tutorialspoint.com/csharp/csharp_variables.htm
// https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/properties

namespace BasicExamples.Examples
{
    public class Character
    {
        private string name = "No Name";
        
        public string Name 
        {
            get => name;
            set {
                name = value;
            }
            
        }

    }
}
