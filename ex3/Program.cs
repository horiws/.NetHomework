using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3
{
    interface Shape{
        double CalculateArea();
        bool IsLegal();
    }

    class Rectangle: Shape {
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

        virtual public bool IsLegal()
        {
            if (width <= 0 || length <= 0)
            {
                return false;
            }
            return true;
        }

        virtual public double CalculateArea()
        {
            if (!IsLegal())
            {
                Console.WriteLine("Illegal shape!");
                return 0;
            }
            return width * length;
        }   
    }

    class Square: Rectangle, Shape
    {
        private double side;
        public double Side
        {
            get => side;
            set => side = value;
        }

        public Square(double side):base(side,side) {
            this.side = side;
        }

        override public bool IsLegal()
        {
           return side > 0;
        }
        override public double CalculateArea()
        {
            if (IsLegal())
            {
                return side * side;
            }
            else
            {
                Console.WriteLine("Illegal square!");
                return 0;
            }
        }
    }

    class Triangle: Shape
    {
        private double sideA;
        private double sideB;
        private double sideC;

        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        public Triangle(double a, double b,double c)
        {
            this.sideA = a;
            this.sideB = b;
            this.sideC = c;
        }
        public bool IsLegal()
        {
            if(sideA + sideB <= sideC || sideB + sideC <= sideA || sideA + sideC <= sideB)
            {
                return false;
            }
            return true;
        }

        public double CalculateArea()
        {
            if (IsLegal())
            {
                double p = 0.5 * (sideA + sideB + sideC);
                return Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
            }
            else
            {
                Console.WriteLine("Illegal shape!");
                return 0;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            double recArea = 0;
            double squArea = 0;
            double triArea = 0;

            Rectangle rectangle = new Rectangle(1.2, 5);
            Square square = new Square(6);
            Triangle triangle = new Triangle(3, 4, 5);

            recArea = rectangle.CalculateArea();
            squArea = square.CalculateArea();
            triArea = triangle.CalculateArea();

            Console.WriteLine($"The area of the rectangle/square/triangle is" +
                $" {recArea} / {squArea} / {triArea} in sequence.");

            Console.Read();
        }
    }
}
