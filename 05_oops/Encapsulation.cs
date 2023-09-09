using System;

/* long format */
// class Person
// {
//   private string name;

//   public string Name
//   {
//     get { return name; }
//     set { name = value; }
//   }
// }

class Person
{
  public string Name { get; set; }
}

class Program
{
  static void Main(string[] args)
  {
    Person myObj = new Person();
    myObj.Name = "Liam";
    Console.WriteLine(myObj.Name);
  }
}