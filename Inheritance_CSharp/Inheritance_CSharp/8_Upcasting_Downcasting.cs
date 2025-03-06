using System;

class Person
{
    public void Display()
    {
        Console.WriteLine("I am a person.");
    }
}

class Student : Person
{
    public void Study()
    {
        Console.WriteLine("I am studying.");
    }
}
