using System;
class Program{
  public static void Main(string[] args) {

    double a = double.Parse(Console.ReadLine());
    double b = double.Parse(Console.ReadLine());
    Console.WriteLine($"{(b/12)*a:0.000}");
    
  }
}