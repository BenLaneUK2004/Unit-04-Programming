//Student Grade Calculator
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Please enter score:");
        Int32 score = Convert.ToInt32(Console.ReadLine());

        if (score > 100 || score < 0)
        {
            Console.WriteLine("INVALID INPUT");
        }
        else if (score >= 90 && score <= 100)
        {
            Console.WriteLine("Grade: [A]");
        }
        else if (score >= 80 && score <= 89)
        {
            Console.WriteLine("Grade: [B]");
        }
        else if (score >= 70 && score <= 79)
        {
            Console.WriteLine("Grade: [C]");
        }
        else if (score >= 60 && score <= 69)
        {
            Console.WriteLine("Grade: [D]");
        }
        else if (score < 60)
        {
            Console.WriteLine("Grade: [F]");
        }
    }
}
