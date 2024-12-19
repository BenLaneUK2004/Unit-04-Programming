//Calculate area of a circle
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Please enter a radius:");
        double radius = Convert.ToDouble(Console.ReadLine());
        double result = Math.Round(Math.PI * Math.Pow(radius, 2), 2);
        Console.WriteLine($"Area of a circle with the radius {radius} is {result}");
    }
}