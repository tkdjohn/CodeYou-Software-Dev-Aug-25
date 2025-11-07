internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, Joe! how are  you?");
        Console.Write("my first line of code> \f >> ");
        Console.WriteLine("look I'm on the same line.");
        var five = 5;
        Console.WriteLine(five);
        Console.WriteLine(five++);
        Console.WriteLine(five);
        Console.WriteLine(++five);
        Console.WriteLine(five);

        Console.WriteLine("================");
        Console.Write("Enter your name: ");
        var name = Console.ReadLine();
        Console.WriteLine($"Hello, {name}!");
    }
}