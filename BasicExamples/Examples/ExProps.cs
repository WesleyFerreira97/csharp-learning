using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// https://www.c-sharpcorner.com/article/understanding-properties-in-C-Sharp/
// https://www.tutorialspoint.com/csharp/csharp_variables.htm
// https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/properties
// https://www.w3schools.com/cs/cs_properties.php

namespace BasicExamples.Examples
{
    public class ExProps
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


