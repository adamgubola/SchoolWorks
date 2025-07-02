using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ClassHierarch
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Shape[] shapes = new Shape[5];

            shapes[0] = new Circle(10, "red");
            shapes[1] = MakeRectangleOrSquare("Orange", 15,15);
            shapes[2] = MakeRectangleOrSquare("Yellow", 30, 15);
            shapes[3] = new Circle(10, "red");
            shapes[4] = new Square("Blue",20);

            MakeHole(shapes[0]);
            Console.WriteLine(shapes[0].ToString());
            Console.WriteLine("____________________");

            Shape[] biggestShapes = BiggestAreaOrdering(shapes);

            foreach (Shape shape in biggestShapes) { Console.WriteLine(shape.ToString()); }

            Console.WriteLine("_____________");
            Console.WriteLine(MaxArea(shapes).ToString());



        }

        public static void MakeHole(Shape shape)
        {
            if (shape.Area() > shape.Premiter()) { shape.MakeHoley(); }
        }
        public static Shape MakeRectangleOrSquare(string color,int  height, int width)
        {


            if (width != height)
            {
                return new Rectangle(color, height, width);
            }
            else 
            { 
                return new Square(color,height);
            
            }
        }

        public static Shape[] BiggestAreaOrdering(Shape [] shape)
        {
            Shape temp = null;

            Shape[]shapes = new Shape[shape.Length];

            for (int i = 0; i < shape.Length; i++)
            {
                shapes[i]= shape[i];
            }

            for(int i = 0;i < shapes.Length-1; i++) 
            {

                for (int j = i; j < shapes.Length; j++) 
                {
                    if (shapes[i].Area() > shapes[j].Area())
                    {
                        temp = shapes[i];
                        shapes[i] = shapes[j];
                        shapes[j] = temp;
                    }

                }
         
            }
            return shapes;
        }

        public static Shape MaxArea(Shape [] shape)
            { 

            int max = 0;
            Shape tempShape= null;

            for (int i = 0; i < shape.Length; i++) 
            { 
            if(shape[i].Area() > max) 
                { tempShape = shape[i]; 
                  max = shape[i].Area(); 
                }
            }
        return tempShape;
     
        }
    }
}
