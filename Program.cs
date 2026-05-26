class Assignment3
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Your Name: ");
        string? name = Console.ReadLine();

        Console.Write("Enter Your Age: ");
        int? age = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Your CGPA: ");
        double? cgpa = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"CGPA: {cgpa}");
    }
}
