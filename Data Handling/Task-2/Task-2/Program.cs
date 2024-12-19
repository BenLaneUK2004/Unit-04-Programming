//Calculate area of a rectangle
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Please enter the length:");
        double length = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Please enter the Width:");
        double width = Convert.ToDouble(Console.ReadLine());
        double result = Math.Round(length * width, 2);
        Console.WriteLine($"Area of a rectangle with a length of {length} and a width of {width} is {result}");
    }
}