using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace CsharpProject.ENUM_And_Struct
{
    public class EnumClas

    {
        public enum level
        {
            Venus,
            Mercury,
            Earth,
            Mars,
            Jupiter,
            Saturn,
            Neptune,
            Pluto
        }

        public static void Mainnn()
        {

            EnumClas enumClas = new EnumClas();
            Console.WriteLine(EnumClas.level.Mars);
           


        }

    }
    public class EnumCls 
    {
        public static void Mattin()
        {

            //EnumClas enumClas = new EnumClas();
            Console.WriteLine(EnumClas.level.Mars);



        }
    }

}

