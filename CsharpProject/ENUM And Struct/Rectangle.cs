using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpProject.ENUM_And_Struct
{//C# Struct Example
    public class Rectangle
    {

        public int width, height;

    }
    public class TestStructs
    {
        public static void cbain()
        {
            Rectangle r = new Rectangle();
            r.width = 4;
            r.height = 5;
            Console.WriteLine("Area of Rectangle is: " + (r.width * r.height));
        }
    }
    // C# Struct Example: Using Constructor and Method
    public struct Rectanglle
    {
        public int width, height;

        public Rectanglle(int w, int h)
        {
            width = w;
            height = h;
        }
        public void areaOfRectangle()
        {
            Console.WriteLine("Area of Rectangle is: " + (width * height));
        }
    }
    public class TestStructss
    {
        public static void Main()
        {
            Rectanglle r = new Rectanglle(5, 6);
            r.areaOfRectangle();
        }

    }
}
