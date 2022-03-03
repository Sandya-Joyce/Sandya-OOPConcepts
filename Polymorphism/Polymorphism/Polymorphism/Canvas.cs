using System.Collections.Generic;

namespace Polymorphism
{
    public class Canvas
    {
        public void DrawShapes(List<Shape> shapes)
        {
            foreach (Shape shape in shapes)
            { 
                shape.Draw(); 
            }
        
        }

    }
}
