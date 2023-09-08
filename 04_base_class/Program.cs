using System;
using Vehicle; // Import the Vehicle namespace

class Program
{
    static void Main()
    {
        Car myCar = new Car();
        Truck myTruck = new Truck();

        myCar.DisplayColor();  // Output: red
        myTruck.DisplayColor(); // Output: blue
    }
}
