using System;

namespace basic_shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle1=new Rectangle(34,25);
            Rectangle rectangle2=new Rectangle(10,5);
            Rectangle rectangle3=new Rectangle(15,30);
            Console.WriteLine("The area of the first rectangle is: {0}",rectangle1.GetArea());
            Console.WriteLine("The area of the second rectangle is: {0}",rectangle2.GetArea());
            Console.WriteLine("The area of the third rectangle is: {0}",rectangle3.GetArea());
            Console.ReadKey(true);
        }
    }
}
