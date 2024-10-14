
class Program
{
    static double AreaOfCircle1(double radius)
    {
        return Math.PI * Math.Pow(radius, 2);
    }
    static void Main(string[] args)
    {
       Console.WriteLine("Enter the radius of the circle:");
        double radius = double.Parse(Console.ReadLine());
        double area = AreaOfCircle1(radius); 
        Console.WriteLine($"The area of the circle with radius {radius} is {area}");
    }
    }
