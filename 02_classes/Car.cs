using System;

public class Car
{
    string color = "red";

    public void DisplayColor()
    {
        Console.WriteLine(color);
    }
}

class Program
{
    static void Main()
    {
        Car myObj = new Car();
        myObj.DisplayColor();
    }
}
