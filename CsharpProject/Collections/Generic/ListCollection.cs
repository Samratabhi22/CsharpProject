using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpProject.Collections.Generic
{
    public class ListCollection
    {
        public static void Matin(string[] args)
        {
            // Create a list of strings  
            var names = new List<string>();
            names.Add("Sonoo Jaiswal");
            names.Add("Ankit");
            names.Add("Peter");
            names.Add("Irfan");

            // Iterate list element using foreach loop  
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
