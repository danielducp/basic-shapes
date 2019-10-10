using System;

namespace basic_shapes
{

    public class ShapeClass{
           protected int length;
         protected   int width;

         
        public ShapeClass()
        {
        
        }
    }

    public class RectangleClass : ShapeClass
    {

         public int GetArea(){

          return  width * length;
        }
         public RectangleClass(int width,int length)
        {
                    this.width=width;
        this.length=length;
        }

       
    }
    class Program
    {
        static void Main(string[] args)
        {
            RectangleClass rectangle1=new RectangleClass(34,25);
            RectangleClass rectangle2=new RectangleClass(10,5);
            RectangleClass rectangle3=new RectangleClass(15,30);
            Console.WriteLine("The area of the first rectangle is: {0}",rectangle1.GetArea());
            Console.WriteLine("The area of the second rectangle is: {0}",rectangle2.GetArea());
            Console.WriteLine("The area of the third rectangle is: {0}",rectangle3.GetArea());
            Console.ReadKey(true);
        }
    }
}
