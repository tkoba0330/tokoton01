using System;

public static class B : A
{
    public override static void Say()
    {
        Console.WriteLine("My name is B!");
    }
}

class Program
{
    static void Main(string[] args)
    {
        B.Say();
    }
}