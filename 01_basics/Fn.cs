using System;

class Fn 
{
    static void MyMethod() 
    {
        Console.WriteLine("I just got executed!");
    }

    static void Main()
    {
        MyMethod();
        Console.ReadKey();
    }
}
