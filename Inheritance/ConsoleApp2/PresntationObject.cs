using System;

namespace Inheritance
{
    class PresntationObject
    {
        public int Height { get; set; } 
        public int Width { get; set; }


        public void Copy()
        {
            Console.WriteLine("Copied to Clipboard");
        }

        public void Duplicate()
        {
            Console.WriteLine("Object was duplicated");
        }

    }
}
