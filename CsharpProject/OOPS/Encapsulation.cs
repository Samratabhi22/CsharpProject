using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static CsharpProject.OOPS.Encapsulation;

namespace CsharpProject.OOPS
{
    internal class Encapsulation
    {

    }
    public class Employee
    {



        public String name { get; set; }
        public int eid { get; set; }
        public double salary { get; set; }
        public string designation { get; set; }

        public void work()
        {

            Console.WriteLine(name + "is working as" + designation);

        }

        public Employee(String name, int eid, double salary, String designation)
        {
            this.name = name;
            this.eid = eid;
            this.salary = salary;
            this.designation = designation;
        }



    }
    public class Driver1
    {

        public static void gain(String[] args)
        {

            Employee e1 = new Employee("Abhi", 1, 50000.0, "Test Engineer");
            Employee e2 = new Employee("Panthal", 2, 70000.0, "Developer");
            Employee e3 = new Employee("Lakshmi", 3, 60000.0, "HR");

            e1.eid = 4; //modifying value of a variable
            Driver1 d = new Driver1();
            d.displayDetails(e1);
            //Driver1. displayDetails(e2);
            //Driver1.displayDetails(e3);
        }
        public void displayDetails(Employee s)
        {
            Console.WriteLine("Name :" + s.name);// Reading value of variable
            Console.WriteLine("Eid :" + s.eid);
            Console.WriteLine("Salary :" + s.salary);
            Console.WriteLine("Designation :" + s.designation);
            s.work();
            Console.WriteLine("======================================================================");

        }

    }
    public class Inherit
    {
        public static int a=10;
        public void test1()
        {
            Console.WriteLine("From non static test() of C");
        }

    }
    public class InheritDriver : Inherit
    {

        public static void pain(String[] args)
        {
            Inherit obj1 = new Inherit();//super class object
            Console.WriteLine(Inherit.a);

            obj1.test1();
        }
    }
    
}
