using System;

class Product
{
    public string Name { get; set; }
    public double Price { get; set; }

    public virtual double GetDiscountedPrice()
    {
        return Price;
    }
}

class ElectronicProduct : Product
{
    public override double GetDiscountedPrice()
    {
        return Price * 0.9;
    }
}

class ClothingProduct : Product
{
    public override double GetDiscountedPrice()
    {
        return Price * 0.8;
    }
}