using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace CsharpProject.OOPS
{
   public abstract class AbstractCls
    {
        public abstract void AnimalSound();
        public void sleep()
        {
            Console.WriteLine("animal sleeps");
        }
    }
    public class Abstrat : AbstractCls                  
    {
       

        public override void AnimalSound()
        {
            Console.WriteLine("Animal makes sound");
        }
    }
    public class Prog
    {
       public  static void bain(string[] args)
        {
            Abstrat my = new Abstrat(); 
            
            my.AnimalSound(); 
            my.sleep();  
        }
    }
    


}
