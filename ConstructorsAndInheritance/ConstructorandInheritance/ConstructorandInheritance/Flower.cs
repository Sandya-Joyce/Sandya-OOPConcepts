using System;

namespace ConstructorandInheritance
{
    public class Flower
    {
        private readonly string _color;

       
        public Flower(string color)
        {
            _color = color;  
            Console.WriteLine("The Color of the Flower is {0}",color);
        }
       
    }
}
