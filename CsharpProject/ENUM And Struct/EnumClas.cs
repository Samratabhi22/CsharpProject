using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpProject.ENUM_And_Struct
{
    public class EnumClas
    {
        enum Level
        {
            //Venus = 0,//by default its value is 0
            Venus = 5, //if we change chane it to 1 or 5 it will change and move so on 
           Mercury,
           Earth,
           Mars,
           Jupiter,
           Saturn,
           Neptune,
           Pluto

        }
       public  static void Main(string[] args)
        {
            Level myVar = Level.Earth;
            Console.WriteLine(myVar);
        }
    }
}
