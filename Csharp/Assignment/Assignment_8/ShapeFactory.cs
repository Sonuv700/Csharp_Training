using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_8
{
    public class ShapeFactory
    {
        public static IShapes GetShapes(string typesofshape)
        {
            IShapes ishapes = null;
            if (typesofshape == "rectangle")
            {
                ishapes = new Rectangle();
            }
            else if (typesofshape == "circle")
            {
                ishapes = new Circle();
            }
            else if (typesofshape == "triangle")
            {
                ishapes = new Triangle();
            }
            else if (typesofshape == "square")
            {
                ishapes = new Square();
            }
            return ishapes;
        }
    }
}