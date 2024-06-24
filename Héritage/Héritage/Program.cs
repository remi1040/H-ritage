using Héritage;

class Program
{
    public static void Main(string[] args)
    {
        Bipede a1 = new Bipede("Singe");

        Quadrupede q1 = new Quadrupede("Elephant");

        Console.WriteLine(a1.Move());
        Console.WriteLine(q1.Move());
    }
}