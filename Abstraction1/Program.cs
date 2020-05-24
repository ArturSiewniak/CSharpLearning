using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction1
{
    public interface Drawable
    {
        void draw();
    }

    public class Rectangle1 : Drawable
    {
        public void draw()
        {
            Console.WriteLine("<Drawing a rectangle1>");
        }
    }

    public class Circle1 : Drawable
    {
        public void draw()
        {
            Console.WriteLine("<Drawing a circle1>");
        }
    }
    public abstract class Shape
    {
        public abstract void draw();
    }

    public class Rectangle : Shape
    {
        public override void draw()
        {
            Console.WriteLine("<Drawing a rectangle>");
        }
    }

    public class Circle : Shape
    {
        public override void draw()
        {
            Console.WriteLine("<Drawing a circle>");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Shape s;
            s = new Rectangle();
            s.draw();
            s = new Circle();
            s.draw();

            Drawable d;
            d = new Rectangle1();
            d.draw();
            d = new Circle1();
            d.draw();
        }
    }
}
