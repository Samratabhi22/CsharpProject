using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpProject.Collections
{
    public class HashSetCollection
    {
        public static void Mavin()
        {
            var hs = new HashSet<string>();
            hs.Add("A");
            hs.Add("B");    
            hs.Add("C");
            hs.Add("D");
            hs.Add("E");
            hs.Add("A");//duplicates
            hs.Add("B");//duplicates
            hs.Add("C");//duplicates
            hs.Add("D");//duplicates
            foreach (var item in hs)
            {
                Console.WriteLine(item);
            }
            foreach (var item in hs)
            {
                Console.WriteLine(item);
            }
        }
    }
}
