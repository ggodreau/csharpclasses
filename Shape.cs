using System;
using System.Collections;
using System.Collections.Generic;

namespace MethodOverriding
{

    public class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("draw a circle");
        }
    }

    public class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("draw a rectangle");
        }
    }

    public class Triangle: Shape
    {
        public override void Draw()
        {
            Console.WriteLine("draw a Triangle");
        }
    }

    public class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public virtual void Draw()
        {

        }
    }

}
