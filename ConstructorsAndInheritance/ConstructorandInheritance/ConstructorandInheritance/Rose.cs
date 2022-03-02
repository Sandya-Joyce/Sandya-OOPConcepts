using System;

namespace ConstructorandInheritance
{
    public class Rose: Flower
    {
        public Rose(string color) : base(color)
        {

            Console.WriteLine("Rose color is {0}",color);
        }

       
    }
}
