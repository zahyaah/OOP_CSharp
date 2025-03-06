using System;

interface IFlyable
{
    void Fly();
}

interface ISwimmable
{
    void Swim();
}

class Duck : IFlyable, ISwimmable
{
    public void Fly()
    {
        Console.WriteLine("Duck is flying...");
    }

    public void Swim()
    {
        Console.WriteLine("Duck is swimming...");
    }
}