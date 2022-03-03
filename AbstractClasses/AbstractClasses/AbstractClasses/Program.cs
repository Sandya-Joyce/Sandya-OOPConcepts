using System;

namespace AbstractClasses
{
    public abstract class Shape
    {
        public string Height { get; set; }
        public string Width { get; set; }
        public abstract void Draw();

        public void copy()
        {
            Console.WriteLine("Copied to the Clipboard");
        }

        public void select()
        {
            Console.WriteLine("Select the Shape");
        }
    }


    public class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a Rectangle");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var rectangle = new Rectangle();
            rectangle.Draw();
        }
    }
}
