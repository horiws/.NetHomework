using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3_2
{
    public abstract class Shape
    {
        public abstract double CalculateArea();
        public abstract bool IsLegal();
    }

    public class Rectangle : Shape
    {
        private double length;
        private double width;

        public double Length
        {
            get => length;
            set => length = value;
        }

        public double Width
        {
            get => width;
            set => width = value;
        }

        public Rectangle(double width, double length)
        {
            this.width = width;
            this.length = length;
        }

        override public bool IsLegal()
        {
            if (width <= 0 || length <= 0)
            {
                return false;
            }
            return true;
        }

        override public double CalculateArea()
        {
            if (!IsLegal())
            {
                Console.WriteLine("Illegal rectangle!");
                return 0;
            }
            return width * length;
        }
    }

    public class Square : Rectangle
    {
        private double side;
        public double Side
        {
            get => side;
            set => side = value;
        }

        public Square(double side) : base(side, side) {
            this.side = side;
        }

        override public bool IsLegal()
        {
            return side > 0;
        }
        override public double CalculateArea()
        {
            if (!IsLegal())
            {
                Console.WriteLine("Illegal square!");
                return 0;
            }
            return side * side;
        }
    }

    public class Triangle : Shape
    {
        private double sideA;
        private double sideB;
        private double sideC;

        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        public Triangle(double a, double b, double c)
        {
            this.sideA = a;
            this.sideB = b;
            this.sideC = c;
        }
        override public bool IsLegal()
        {
            if (sideA + sideB <= sideC || sideB + sideC <= sideA || sideA + sideC <= sideB)
            {
                return false;
            }
            return true;
        }

        override public double CalculateArea()
        {
            if (IsLegal())
            {
                double p = 0.5 * (sideA + sideB + sideC);
                return Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
            }
            else
            {
                Console.WriteLine("Illegal triangle!");
                return 0;
            }
        }
    }

    public class ShapeFactory
    {
        public static Shape CreateShape(double a)
        {
            Shape shape = new Square(a);
            return shape;
        }
        public static Shape CreateShape(double a, double b)
        {
            Shape shape = new Rectangle(a, b);
            return shape;
        }
        public static Shape CreateShape(double a, double b, double c)
        {
            Shape shape = new Triangle(a, b, c);
            return shape;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;

            sum += ShapeFactory.CreateShape(1.2, 5).CalculateArea();    //the 1st shape
            sum += ShapeFactory.CreateShape(3, 4, 5).CalculateArea();
            sum += ShapeFactory.CreateShape(9, 12, 7).CalculateArea();
            sum += ShapeFactory.CreateShape(4, 6).CalculateArea();
            sum += ShapeFactory.CreateShape(2, 10).CalculateArea();
            sum += ShapeFactory.CreateShape(9).CalculateArea();         //the 6th shape
            sum += ShapeFactory.CreateShape(6, 8, 10).CalculateArea();
            sum += ShapeFactory.CreateShape(2.4).CalculateArea();
            sum += ShapeFactory.CreateShape(5, 8).CalculateArea();
            sum += ShapeFactory.CreateShape(8, 9).CalculateArea();

            Console.WriteLine($"The sum of the 10 shapes' area is {sum}.");
            Console.Read();

        }
    }
}
