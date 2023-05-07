using System;



public abstract class Boss
{
    public abstract string GetName();
    public abstract float GetArea();
}
class Quadrilateral : Boss
{
    public override string GetName()
    {
        return "Quadrilateral";
    }

    public float a { get; set; }
    public float b { get; set; }
    public float c { get; set; }
    public float d { get; set; }
    public  override float GetArea()
    {
        float perimeter = (a + b + c + d) / 2;
        return (float)Math.Sqrt((perimeter - a) * (perimeter - b) * (perimeter - c) * (perimeter - d));
    }
}

class Parallelogram : Boss
{
    public override string GetName()
    {
        return "Parallelogram";
    }

    public float Base { get; set; }
    public float Height { get; set; }

    public override float GetArea()
    {
        return Base * Height;
    }
}



class Rhomb : Boss
{
    public override string GetName()
    {
        return "Rhomb";
    }

    public float Diagonal1 { get; set; }
    public float Diagonal2 { get; set; }

    public override float GetArea()
    {
        return (Diagonal1 * Diagonal2) / 2;
    }
}

class Rectangle : Boss
{
    public override string GetName()
    {
        return "Rectangle";
    }

    public float SideA { get; set; }
    public float SideB { get; set; }

    public override float GetArea()
    {
        return SideA * SideB;
    }
}

class Square : Boss
{
    public override string GetName()
    {
        return "Square";
    }

    public float Side { get; set; }

    public override float GetArea()
    {
        return Side * Side;
    }
}

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Please choose a figure: ");
            Console.WriteLine("1.Quadrilateral");
            Console.WriteLine("2. Parallelogram");
            Console.WriteLine("3. Rhomb");
            Console.WriteLine("4. Rectangle");
            Console.WriteLine("5. Square");

            int choice = int.Parse(Console.ReadLine());

            Boss figure;

            switch (choice)
            {
                case 1:
                    figure = new Quadrilateral { a = 3, b = 4, c = 6, d = 8 };
                    break;
                case 2:
                    figure = new Parallelogram { Base = 6, Height = 4 };
                    break;
                case 3:
                    figure = new Rhomb { Diagonal1 = 8, Diagonal2 = 10 };
                    break;
                case 4:
                    figure = new Rectangle { SideA = 17, SideB = 14 };
                    break;
                case 5:
                    figure = new Square { Side = 5 };
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please choose a valid option.");
                    continue;
            }

            Console.WriteLine($"Figure: {figure.GetName()} | Area: {figure.GetArea()}");

            Console.WriteLine("Do you want to continue? (Y/N)");
            string input = Console.ReadLine().ToUpper();

            if (input == "N")
            {
                break;
            }
        }
    }
}
