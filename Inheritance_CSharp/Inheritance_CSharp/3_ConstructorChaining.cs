using System;

class Employee
{
    public string Name { get; set; }
    public double Salary { get; set; }

    public Employee(string name, double salary)
    {
        Name = name;
        Salary = salary;
    }
}

class Manager : Employee
{
    public double Bonus { get; set; }

    public Manager(string name, double salary, double bonus) : base(name, salary)
    {
        Bonus = bonus;
    }
}
