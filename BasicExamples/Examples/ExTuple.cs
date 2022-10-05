using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/value-tuples
// https://www.tutorialsteacher.com/csharp/csharp-tuple
// https://zetcode.com/csharp/tuple/
// https://balta.io/blog/csharp-tuple

namespace BasicExamples.Examples
{
    internal class ExTuple
    {
        public void Ex1()
        {
            // Este tipo de tupla pode ter seus valores renomeados
            (string Name, string LastName, int Age) people =
            ("Wesley", "Ferreira", 25);

            Console.WriteLine(people.Name);
            Console.WriteLine(people.LastName);
            Console.WriteLine(people.Age);
        }  
        public void Ex2()
        {
            ValueTuple<string, string, int> people2 =
                ("Wesley", "Ferreira", 25);

            // Não pode ser renomeado Item1, Item2, Item3
            Console.WriteLine(people2.Item1);
            Console.WriteLine(people2.Item2);
            Console.WriteLine(people2.Item3);
        }  
        public void Ex3()
        {
            // Tupla com tipagem automatica
            var outraPessoa = Tuple.Create("Wesley", "Ferreira", 25);
            Console.WriteLine(outraPessoa.Item1);
            Console.WriteLine(outraPessoa.Item2);
            Console.WriteLine(outraPessoa.Item3);
        }
    }
}
