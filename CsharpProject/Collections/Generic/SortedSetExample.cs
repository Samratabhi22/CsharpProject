using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpProject.Collections.Generic
{
    public class SortedSetExample
    {
        public static void Mlain(string[] args)
        {
            // Create a set of strings  
            var names = new SortedSet<string>();
            names.Add("Sonoo");
            names.Add("Ankit");
            names.Add("Peter");
            names.Add("Irfan");
            names.Add("Ankit");//will not be added  

            // Iterate SortedSet elements using foreach loop  
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
        public class SortedSetExampl
        {
            public static void Mavin(string[] args)
            {
                // Create a set of strings  
                var names = new SortedSet<string>() { "Sonoo", "Ankit", "Peter", "Irfan" };

                // Iterate SortedSet elements using foreach loop  
                foreach (var name in names)
                {
                    Console.WriteLine(name);
                }
            }
        }
    }
}
