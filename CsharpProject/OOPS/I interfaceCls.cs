using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpProject.OOPS
{
    public interface I_interfaceCls
    {
        void VehiclesMoves();
        
        

    }
    public class Cars
    {
        public void VehiclesMoves() 
        {
            Console.WriteLine("Car is moving");

        }
        public static void Main(string[] args)
        {
            Cars my = new Cars();
            my.VehiclesMoves();


        }
    }
}
