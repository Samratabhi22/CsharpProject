using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpProject.Collections.Nongeneric
{
    internal class NonGenericCollections

    {
        public class ArrayListCls
        {
            public static void Mabin()

            {
                //
                // Summary:
                //     Implements the System.Collections.IList interface using an array whose size is
                //     dynamically increased as required.



                ArrayList arrayList = new ArrayList();

                //ArrayList arrayList = new ArrayList(10);//here capacity is declared 10
                //it will take as 10, 20 40 and so on....

                //or
                // var arlist = new ArrayList(); // recommended 
                //knowing the initial capacity of Arraylist

                Console.WriteLine(arrayList.Capacity);//initial capacity of arraylist is zero
                //inserting the first value to array list 
                arrayList.Add(100);

                //again knowing the arraylist capacity
                Console.WriteLine(arrayList.Capacity);//capacity of arraylist second time is 4

                arrayList.Add(100);//taking duplicate values also
                arrayList.Add(null);//taking null value also
                arrayList.Add("Hello");//taking string also
                arrayList.Add(" ");//taking space as string also


                arrayList.Add("Hello");//taking string also
                //again knowing the arraylist capacity
                Console.WriteLine(arrayList.Capacity);//capacity of arraylist second time is 8

                //capacity---> 0 4 8 16 32 64
                arrayList.Add('a');
                arrayList.Add(true);
                arrayList.Add(10.54);//taking double values 

                ///taking all types of values 
                ///so Arraylist is no particular datatype but size is auto sizing



                arrayList.Add(200);

                //
                // Summary:
                //     Adds an object to the end of the System.Collections.ArrayList.
                //
                // Parameters:
                //   value:
                //     The System.Object to be added to the end of the System.Collections.ArrayList.
                //     The value can be null.
                //
                // Returns:
                //     The System.Collections.ArrayList index at which the value has been added.
                //
                // Exceptions:
                //   T:System.NotSupportedException:
                //     The System.Collections.ArrayList is read-only. -or- The System.Collections.ArrayList
                //     has a fixed size.





                arrayList.Add(null);//taking null value also
                arrayList.Add(300);




                arrayList.Add(400);
                //again knowing the arraylist capacity
                Console.WriteLine(arrayList.Capacity);
                arrayList.Add(500);
                //again knowing the arraylist capacity
                Console.WriteLine(arrayList.Capacity);
                arrayList.Add(600);
                //printing all the value using for each loop

                foreach (object obj in arrayList)
                {
                    Console.Write(obj + " ");
                    Console.WriteLine();
                }
                //inserting the values in arraylist
                arrayList.Insert(3, 350);
                //reprinting the values again after inserting

                foreach (object obj in arrayList)
                {
                    Console.Write(obj + " ");
                    Console.WriteLine();
                }
                //removing the values of 200
                arrayList.Remove(200);
                //reprinting the values again after inserting
                foreach (object obj in arrayList)
                {
                    Console.Write(obj + " ");
                    Console.WriteLine();
                }
                ////removing the value from index 3
                arrayList.RemoveAt(3);
                //reprinting the values again after inserting
                foreach (object obj in arrayList)
                {
                    Console.Write(obj + " ");
                    Console.WriteLine();
                }



            }
        }
    }
}
