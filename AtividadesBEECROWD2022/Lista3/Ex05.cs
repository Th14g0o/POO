using System;
class Program{
  public static void Main(string[] argas) {

    string Ns1 = Console.ReadLine();
    string Ns2 = Console.ReadLine();
    string[] numeros1 = Ns1.Split();
    string[] numeros2 = Ns2.Split();
    double x1 = double.Parse(numeros1[0]);
    double y1 = double.Parse(numeros1[1]);
    double x2 = double.Parse(numeros2[0]);
    double y2 = double.Parse(numeros2[1]);
    Console.WriteLine($"{Math.Sqrt((Math.Pow((x1-x2), 2) + Math.Pow((y1-y2), 2))):0.0000}");
    
  }
}