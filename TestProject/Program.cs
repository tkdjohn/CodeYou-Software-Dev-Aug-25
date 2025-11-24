internal class Program
{
    private static void Main(string[] args)
    {
        // Console.WriteLine("Hello, Joe! how are  you?");
        // Console.Write("my first line of code> \f >> ");
        // Console.WriteLine("look I'm on the same line.");
        // var five = 5;
        // Console.WriteLine(five);
        // Console.WriteLine(five++);
        // Console.WriteLine(five);
        // Console.WriteLine(++five);
        // Console.WriteLine(five);

        // Console.WriteLine("================");
        // Console.Write("Enter your name: ");
        // string name = Console.ReadLine();
        // Console.WriteLine($"Hello, {name}!");

        Person person1 = new Person();
        person1.Name = "Jaron is funny";
        person1.Id = 0;

        Person person2 = new Person(1, "Felipe is funny");

        Console.WriteLine(person1.Name);
        Console.WriteLine(person2.Name);
    }
}