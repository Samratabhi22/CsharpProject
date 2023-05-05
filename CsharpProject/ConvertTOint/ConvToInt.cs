using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpProject.ConvertTOint
{
    public class ConvToInt
    {
        public static void Nnnain()
        {
            double doubleNum = 11.52;
           // int intNum;
            int intNum2 = 10;
              int numb  = Convert.ToInt32(intNum2);

            int Num = Convert.ToInt32(doubleNum);
            
            Console.WriteLine("Converted {0} to {1}", Num, numb);
            //Console.WriteLine("Converted {0} to {1}", doubleNum, intNum);
        }
    }
}
