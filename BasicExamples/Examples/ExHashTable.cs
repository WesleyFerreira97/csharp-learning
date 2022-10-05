using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExamples.Examples
{
    internal class ExHashtable
    {
        Hashtable people = new Hashtable();

        public void AddHash(string cpf, string name)
        {
            try
            {
                people.Add(cpf, name);
                Console.WriteLine($"Added : {name}");
            }
            catch
            {
                Console.WriteLine("Element already exists");
            }
        }

        public void RemoveHash(string removeKey)
        {
            people.Remove(removeKey);
        }

        public void GetAllItems()
        {
            foreach (DictionaryEntry item in people)
            {
                Console.WriteLine($"{item.Key} {item.Value}");
            }
        }

        public bool HashContains(string itemKey)
        {
            bool itemContains = people.Contains(itemKey);

            return itemContains;
        }
    }
}