using System;
/* Allows us to delegate a method to an inherited
 * class; forces said child class to implement that method */
namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            var circle = new Circle();
            circle.Draw();

            var rectangle = new Rectangle();
            rectangle.Draw();
        }
    }
}
