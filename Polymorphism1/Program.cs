using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism1
{
    public class Animal2
    {
        public virtual void eat()
        {
            Console.WriteLine("<Eating2>");
        }

        public virtual void run()
        {
            Console.WriteLine("<Running2>");
        }
    }

    public class Dog2 : Animal2
    {
        public override void eat()
        {
            Console.WriteLine("<Eating meat2>");
        }
        public sealed override void run()
        {
            Console.WriteLine("<Running fast2>");
        }
    }
    /*
    public class BabyDog2 : Dog2    
    {
        public override void eat()
        {
            Console.WriteLine("<Consuming flesh2>"); 
        }
        public override void run()  //Overridden method is sealed, doesn't compile
        {
            Console.WriteLine("<Running slowly2>");
        }
    }
    */

    sealed public class Animal1
    {
        public void eat()
        {
            Console.WriteLine("<Eating1>");
        }
    }
    
    /*  
    public class Dog1 : Animal1 //Derived class is sealed, doesn't compile
    {
        public void bark()
        {
            Console.WriteLine("<Bork bork>");
        }
    }
    */
    public class Shape
    {
        public virtual void draw()
        {
            Console.WriteLine("<Drawing>");
        }
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
    public class Animal
    {
        public string color = "White";

        public Animal()
        {
            Console.WriteLine("Animal constructor invoked");
        }
        public virtual void eat()
        {
            Console.WriteLine("<Eating>");
        }
    }

    public class Dog : Animal
    {
        string color = "Black";
        public Dog()
        {
            Console.WriteLine("Dog constructor invoked");
        }
        public override void eat()
        {
            base.eat();
            Console.WriteLine("<Eating meat>");
        }

        public void showColor()
        {
            Console.WriteLine(base.color);
            Console.WriteLine(color);
        }
    }
    public class Cal
    {
        public static int add(int a, int b)
        {
            return a + b;
        }

        public static int add(int a, int b, int c)
        {
            return a + b + c;
        }

        public static float add(float a, float b)
        {
            return a + b;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Cal.add(1, 2));
            Console.WriteLine(Cal.add(1.5f, 2.2f));
            Console.WriteLine(Cal.add(1, 2, 3));

            Dog d1 = new Dog();
            d1.eat();
            d1.showColor();

            Animal a1 = new Dog();
            a1.eat();

            Shape s;
            s = new Shape();
            s.draw();
            s = new Rectangle();
            s.draw();
            s = new Circle();
            s.draw();

            Animal a2 = new Dog();
            Console.WriteLine(a2.color);

        }
    }
}
