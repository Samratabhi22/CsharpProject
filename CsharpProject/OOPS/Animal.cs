using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpProject.OOPS
{
    public class Animal
    { 

        public void add(int a) {
            Console.WriteLine(10+a);
        }
        public void add(int a, int b)
        {
            Console.WriteLine(b + a);
        }

        public virtual void sound()
        {
            Console.WriteLine("Animals makes sound");
        }
        

    }
    public class Dog : Animal
    {
        public override void sound()
        {
            Console.WriteLine("Dog barks");
        }
        public static void rain(string[] args)
        {
            Animal ani = new Animal();
            ani.add(1);
            ani.add(2+3);
            ani.sound();
            Animal dg = new Dog ();
            dg.sound();

        }
    }
    
    
}