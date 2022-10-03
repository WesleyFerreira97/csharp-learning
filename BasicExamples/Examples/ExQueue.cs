using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExamples.Examples
{
    internal class ExQueue
    {
        private Queue<string> nameQueue = new Queue<string>();
        
        public void AddQueue(string name)
        {
            nameQueue.Enqueue(name);

            Console.WriteLine($"Added {name}");
        }

        public void RemoveQueue()
        {
            string dequeueObject = nameQueue.Dequeue();

            Console.WriteLine($"Removed : {dequeueObject}");
        }

        public void GetAllItems()
        {
            foreach (var item in nameQueue)
            {
                Console.WriteLine(item);
            }
        }

        public bool QueueContains(string itemName)
        {
            bool itemContains = nameQueue.Contains(itemName);


            return itemContains;
        }
    }
}