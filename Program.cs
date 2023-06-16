using System;

class Shape
{
    public virtual double GetPerimeter()
    {
        return 0;
    }

    public virtual double GetArea()
    {
        return 0;
    }
}

class Triangle : Shape
{
    private double side1;
    private double side2;
    private double side3;

    public Triangle(double s1, double s2, double s3)
    {
        side1 = s1;
        side2 = s2;
        side3 = s3;
    }

    public override double GetPerimeter()
    {
        return side1 + side2 + side3;
    }

    public override double GetArea()
    {
        double s = GetPerimeter() / 2;
        return Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3));
    }
}

class Polygon : Shape
{
    private double[] sides;

    public Polygon(double[] s)
    {
        sides = s;
    }

    public override double GetPerimeter()
    {
        double perimeter = 0;
        foreach (double side in sides)
        {
            perimeter += side;
        }
        return perimeter;
    }

    public override double GetArea()
    {
        // Assuming the polygon is regular
        double apothem = sides[0] / (2 * Math.Tan(Math.PI / sides.Length));
        double sideLength = sides[0];
        double area = (GetPerimeter() * apothem) / 2;
        return area;
    }
}

class Ellipse : Shape
{
    private double semiMajorAxis;
    private double semiMinorAxis;

    public Ellipse(double a, double b)
    {
        semiMajorAxis = a;
        semiMinorAxis = b;
    }

    public override double GetPerimeter()
    {
        // Using the approximation formula for the perimeter of an ellipse
        double h = Math.Pow(semiMajorAxis - semiMinorAxis, 2) / Math.Pow(semiMajorAxis + semiMinorAxis, 2);
        return Math.PI * (semiMajorAxis + semiMinorAxis) * (1 + ((3 * h) / (10 + Math.Sqrt(4 - (3 * h)))));
    }

    public override double GetArea()
    {
        return Math.PI * semiMajorAxis * semiMinorAxis;
    }
}

class Trapezoid : Shape
{
    private double base1;
    private double base2;
    private double height;
    private double side1;
    private double side2;

    public Trapezoid(double b1, double b2, double h, double s1, double s2)
    {
        base1 = b1;
        base2 = b2;
        height = h;
        side1 = s1;
        side2 = s2;
    }

    public override double GetPerimeter()
    {
        return base1 + base2 + side1 + side2;
    }

    public override double GetArea()
    {
        return ((base1 + base2) / 2) * height;
    }
}

class Program
{
    static void Main(string[] args)
    {
        int choice = 0;
        while (choice != 5)
        {
            Console.WriteLine("Please choose a shape:");
            Console.WriteLine("1. Triangle");
            Console.WriteLine("2. Polygon");
            Console.WriteLine("3. Ellipse");
            Console.WriteLine("4. Trapezoid");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter the length of side 1: ");
                    double side1 = double.Parse(Console.ReadLine());
                    Console.Write("Enter the length of side 2: ");
                    double side2 = double.Parse(Console.ReadLine());
                    Console.Write("Enter the length of side 3: ");
                    double side3 = double.Parse(Console.ReadLine());
                    Triangle t = new Triangle(side1, side2, side3);
                    Console.WriteLine("Perimeter of the triangle: {0:F2}", t.GetPerimeter());
                    Console.WriteLine("Area of the triangle: {0:F2}", t.GetArea());
                    break;

                case 2:
                    Console.Write("Enter the number of sides in the polygon: ");
                    int numSides = int.Parse(Console.ReadLine());
                    double[] sides = new double[numSides];
                    for (int i = 0; i < numSides; i++)
                    {
                        Console.Write("Enter the length of side {0}: ", i + 1
                        1
                        );
                        sides[i] = double.Parse(Console.ReadLine());
                    }
                    Polygon p = new Polygon(sides);
                    Console.WriteLine("Perimeter of the polygon: {0:F2}", p.GetPerimeter());
                    Console.WriteLine("Area of thepolygon: {0:F2}", p.GetArea());
                    break;

                case 3:
                    Console.Write("Enter the length of the semi-major axis: ");
                    double semiMajor = double.Parse(Console.ReadLine());
                    Console.Write("Enter the length of the semi-minor axis: ");
                    double semiMinor = double.Parse(Console.ReadLine());
                    Ellipse e = new Ellipse(semiMajor, semiMinor);
                    Console.WriteLine("Perimeter of the ellipse: {0:F2}", e.GetPerimeter());
                    Console.WriteLine("Area of the ellipse: {0:F2}", e.GetArea());
                    break;

                case 4:
                    Console.Write("Enter the length of the first base: ");
                    double base1 = double.Parse(Console.ReadLine());
                    Console.Write("Enter the length of the second base: ");
                    double base2 = double.Parse(Console.ReadLine());
                    Console.Write("Enter the height: ");
                    double height = double.Parse(Console.ReadLine());
                    Console.Write("Enter the length of side 1: ");
                    double s1 = double.Parse(Console.ReadLine());
                    Console.Write("Enter the length of side 2: ");
                    double s2 = double.Parse(Console.ReadLine());
                    Trapezoid tr = new Trapezoid(base1, base2, height, s1, s2);
                    Console.WriteLine("Perimeter of the trapezoid: {0:F2}", tr.GetPerimeter());
                    Console.WriteLine("Area of the trapezoid: {0:F2}", tr.GetArea());
                    break;

                case 5:
                    Console.WriteLine("Exiting the program...");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
                    break;
            }

            Console.WriteLine();
        }
    }
}