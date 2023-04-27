using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpProject.Collections
{
    public  class ArrayListCls
    {
        public static void nain()
        {
            // Creating an List 
          var  myList = new List<string>();

            // Adding elements to List 
            myList.Add("Abhishek");
            myList.Add("Baba");
            myList.Add("Cutie");
            myList.Add("Danger");
            myList.Add("Elephant");
            myList.Add("Food");
            //Duplicates are allowed
            myList.Add("Cutie");
            //initialization at the time of creation
           var names= new List<string> {"Tysss" ,"TY"};

            Console.WriteLine(names[1]);

            myList.Remove("Baba");//removing Baba

            Console.WriteLine(myList.Remove("Food"));//returns true if it is removed

            //fetching all the items in myList

            foreach ( string name in myList)
            {
                Console.WriteLine(name);
            }
            


        }

    }
    public class LinkedListCls
    {
        public static void ppain()
        {//creating the LinkedList
            var linkedlist = new LinkedList<string>();

            // Adding elements to List 

            linkedlist.AddFirst("one");
            linkedlist.AddFirst("two");
            linkedlist.AddFirst("three");
            linkedlist.AddLast("four");
            linkedlist.AddLast("five");
            linkedlist.AddLast("six");

            //fetching the list in name
            foreach ( string name in linkedlist)
            {
                Console.WriteLine(name);    
            }

            Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");

            //finding the particular element by node

           LinkedListNode<string > node= linkedlist.Find("one");
            //adding element before node
            //adding element after node

            linkedlist.AddBefore(node,"Tyss");
            linkedlist.AddBefore(node, "Ty");

            //fetching and printing the item for added and before

            foreach( string item in linkedlist)
            {
                Console.WriteLine(item);    
            }

        }
    }
    
}
