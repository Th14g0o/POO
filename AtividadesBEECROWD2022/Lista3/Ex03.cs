using System;
class Program{
  public static void Main(string[] argas) {

    double a = double.Parse(Console.ReadLine());
    Console.WriteLine($"VOLUME = {3.14159 * (Math.Pow(a,3)* 4/3.0):0.000}");
    
  }
}