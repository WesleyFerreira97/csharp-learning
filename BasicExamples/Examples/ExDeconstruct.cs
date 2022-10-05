using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExamples.Examples
{
    internal class ExDeconstruct
    {
        private string _name = "Initial Value";
        private string _lastName = "Initial Value";

        public ExDeconstruct() 
        { 

        }

        public ExDeconstruct(string name, string LastName)
        {
            _name = name;
            _lastName = LastName;
        }

        public void Deconstruct(out string name, out string lastName) 
        {
            name = _name;
            lastName = _lastName;
        }

        public void GetAllProps()
        {
            Console.WriteLine(_name);
            Console.WriteLine(_lastName);
        }
    }
}
