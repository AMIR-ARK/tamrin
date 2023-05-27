# tamrin
Write a program using the object-oriented structure that calculates and prints 1_ the perimeter and area of   a triangle 2_ the perimeter and area of   a polygon 3_ the perimeter and area of   an ellipse 4_ the perimeter and area of   a trapezoid at the request of the user
using System;

namespace Geometry
{
    abstract class Shape
    {
        public abstract void CalculateArea();
        public abstract void CalculatePerimeter();
    }

    class Triangle : Shape
    {
        private double a;
        private double b;
        private double c;

        public Triangle()
        {
            Console.WriteLine("Enter the length of the first side of the triangle:");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the length of the second side of the triangle:");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the length of the third side of the triangle:");
            c = Convert.ToDouble(Console.ReadLine());
        }

        public override void CalculateArea()
        {
            double s = (a + b + c) / 2;
            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            Console.WriteLine("The area of the triangle is: {0}", area);
        }

        public override void CalculatePerimeter()
        {
            double perimeter = a + b + c;
            Console.WriteLine("The perimeter of the triangle is: {0}", perimeter);
                           case 1:
                        Triangle triangle = new Triangle();
                        triangle.CalculateArea();
                        triangle.CalculatePerimeter();
                        break;
                    case 2:
                        Polygon polygon = new Polygon();
                        polygon.CalculateArea();
                        polygon.CalculatePerimeter();
                        break;
                    case 3:
                        Ellipse ellipse = new Ellipse();
                        ellipse.CalculateArea();
                        ellipse.CalculatePerimeter();
                        break;
                    case 4:
                        Trapezoid trapezoid = new Trapezoid();
                        trapezoid.CalculateArea();
                        trapezoid.CalculatePerimeter();
                        break;
                    case 0:
                        Console.WriteLine("Exiting the program...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            } while (choice != 0);
        }
    }

    abstract class Shape
    {
        public abstract void CalculateArea();
        public abstract void CalculatePerimeter();
    }

    class Triangle : Shape
    {
        private double a;
        private double b;
        private double c;

        public Triangle()
        {
            Console.WriteLine("Enter the length of the first side of the triangle:");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the length of the second side of the triangle:");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the length of the third side of the triangle:");
            c = Convert.ToDouble(Console.ReadLine());
        }

       public override void CalculateArea()
        {
            double s = (a + b + c) / 2;
            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            Console.WriteLine("The area of the triangle is: {0}", area);
        }

        public override void CalculatePerimeter()
        {
            double perimeter = a + b + c;
            Console.WriteLine("The perimeter of the triangle is: {0}", perimeter);
        }
    }

    class Polygon : Shape
    {
        private int n;
        private double s;

        public Polygon()
        {
            Console.WriteLine("Enter the number of sides of the polygon:");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the length of one side of the polygon:");
            s = Convert.ToDouble(Console.ReadLine());
        }

        public override void CalculateArea()
        {
            double area = (n * Math.Pow(s, 2)) / (4 * Math.Tan(Math.PI / n));
            Console.WriteLine("The area of the polygon is: {0}", area);
        }

        public override void CalculatePerimeter()
        {
            double perimeter = n * s;
            Console.WriteLine("The perimeter of the polygon is: {0}", perimeter);
        }
    }

    class Ellipse : Shape
    {
        private double a;
        private double b;

        public Ellipse()
        {
            Console.WriteLine("Enter the lengthof the major axis of the ellipse:");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the length of the minor axis of the ellipse:");
            b = Convert.ToDouble(Console.ReadLine());
        }

        public override void CalculateArea()
        {
            double area = Math.PI * a * b;
            Console.WriteLine("The area of the ellipse is: {0}", area);
        }

        public override void CalculatePerimeter()
        {
            double perimeter = 2 * Math.PI * Math.Sqrt((Math.Pow(a, 2) + Math.Pow(b, 2)) / 2);
            Console.WriteLine("The perimeter of the ellipse is: {0}", perimeter);
        }
    }

    class Trapezoid : Shape
    {
        private double a;
        private double b;
        private double c;
        private double d;
        private double h;

        public Trapezoid()
        {
            Console.WriteLine("Enter the length of the first base of the trapezoid:");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the length of the second base of the trapezoid:");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the length of one of the non-parallel sides of the trapezoid:");
            c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the length of the other non-parallel side of the trapezoid:");
            d = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enterthe height of the trapezoid:");
            h = Convert.ToDouble(Console.ReadLine());
        }

        public override void CalculateArea()
        {
            double area = ((a + b) / 2) * h;
            Console.WriteLine("The area of the trapezoid is: {0}", area);
        }

        public override void CalculatePerimeter()
        {
            double perimeter = a + b + c + d;
            Console.WriteLine("The perimeter of the trapezoid is: {0}", perimeter);
        }
    }
} 
