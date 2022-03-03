using System;

namespace Polymorphism
{
    public class Shape
    {
        public int Height { get; set; } 
        public int Width { get; set; }


        public virtual void Draw()
        {

        }
        
    }

    public class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a Circle");
        }
    }

    public class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a Rectanglel");
        }
    }
}
