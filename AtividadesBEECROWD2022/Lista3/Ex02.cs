using System;
class Program{
  public static void Main(string[] argas) {

    double a = double.Parse(Console.ReadLine());
    double b = double.Parse(Console.ReadLine());
    Console.WriteLine($"MEDIA = {((a*3.5 ) + (b*7.5))/11:0.00000}");
    
  }
}