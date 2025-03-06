// See https://aka.ms/new-console-template for more information
using System;
using FirstVersion;
using SecondVersion;

class Program
{
    static void Main()
    {
        FirstVersion.Car car1 = new FirstVersion.Car("Toyota", 180);
        FirstVersion.Bike bike1 = new FirstVersion.Bike("Yamaha", 120);

        SecondVersion.Car car2 = new SecondVersion.Car("Honda", 160);
        SecondVersion.Bike bike2 = new SecondVersion.Bike("Ducati", 200);

        Console.WriteLine("Using First Version:");
        car1.DisplayInfo();
        bike1.DisplayInfo();
        
        Console.WriteLine("\nUsing Second Version:");
        car2.DisplayInfo();
        bike2.DisplayInfo();

        Console.WriteLine("\nConstructor Chaining"); 
        Manager manager = new Manager("John Doe", 75000, 10000);
        Console.WriteLine($"Name: {manager.Name}, Salary: {manager.Salary}, Bonus: {manager.Bonus}");

        Console.WriteLine("\nAbstract Class and Polymorphism"); 
        Animal dog = new Dog();
        Animal cat = new Cat();
        
        dog.MakeSound();
        cat.MakeSound();
        
        Console.WriteLine("\nInterface vs Inheritance");
        Robot robot = new Robot();
        robot.Start();
        robot.Move();
        
        Console.WriteLine("\nSealed class and methods");
        SavingsAccount savings = new SavingsAccount();
        savings.CalculateInterest();

        Console.WriteLine("\nMultiple Inheritance using Interface");
        Duck duck = new Duck();
        duck.Fly();
        duck.Swim();
        
        Console.WriteLine("\nUpcasting and Downcasting");
        Student student = new Student();
        Person person = student; // Upcasting
        person.Display();

        Student downcastedStudent = (Student)person; // Downcasting
        downcastedStudent.Study();

        Console.WriteLine("\nE Commerce system");
        ElectronicProduct laptop = new ElectronicProduct { Name = "Laptop", Price = 1000 };
        ClothingProduct shirt = new ClothingProduct { Name = "Shirt", Price = 50 };

        Console.WriteLine($"{laptop.Name} Discounted Price: {laptop.GetDiscountedPrice()}");
        Console.WriteLine($"{shirt.Name} Discounted Price: {shirt.GetDiscountedPrice()}");

        Console.WriteLine("\nPrevent Inheritance using Sealed Class");
        SecuritySystem security = new SecuritySystem();
        security.AuthenticateUser();
    }
}