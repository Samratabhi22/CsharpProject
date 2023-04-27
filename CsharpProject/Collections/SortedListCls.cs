using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpProject.Collections
{
    public  class SortedListCls
    {
        public static void ttain(string[] args)
        {
          var  sortedList=new SortedList<int , string>();
            sortedList.Add(1,"Alpha");
            sortedList.Add(2, "Beta");
            sortedList.Add(3, "Gamma");

            foreach (var item in sortedList)
            {
                Console.WriteLine(item);
            }

        }
    }
}
