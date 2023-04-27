using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpProject.Collections.Generic
{
    public  class QueueExample
    {
        public static void Mapin(string[] args)
        {
            Queue<string> names = new Queue<string>();
            names.Enqueue("Sonoo");
            names.Enqueue("Peter");
            names.Enqueue("James");
            names.Enqueue("Ratan");
            names.Enqueue("Irfan");

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("Peek element: " + names.Peek());
            Console.WriteLine("Dequeue: " + names.Dequeue());
            Console.WriteLine("After Dequeue, Peek element: " + names.Peek());
        }
    }
}


