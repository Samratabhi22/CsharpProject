using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpProject
{
    internal class Pattern
    {
       public  static void aaain()
        {
            string s = "abhishek";
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 0; j < s.Length; j++)
                {
                    if(i==j)
                    {
                        Console.WriteLine(s[i]);
                    }
                    else
                    {
                        Console.WriteLine(" ");
                    }

                }
                Console.WriteLine("");
            }
            
             }

    }
    class ArithmeticOperators
    {
       public  static void sain( string[] args)
        {
            int a = 5, b = 6;
            int c = a + b;
            Console.WriteLine("The addition of two variables " + c);

        }
    }
}
