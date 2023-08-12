internal class Program
{
    private static void Main(string[] args)
    {

        Console.WriteLine("What`s your name?");
        string name=Console.ReadLine();
        Console.WriteLine("Hello "+name+"!");
        Console.WriteLine("Whats your age?");
        int age= int.Parse(Console.ReadLine());
        Console.WriteLine("Your age is "+age+"!");

    }
}