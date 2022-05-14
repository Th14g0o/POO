using System;
class Program{
  public static void Main(string[] args) {

    string abc = Console.ReadLine();
    string[] lista = abc.Split();
    double a = double.Parse(lista[0]);
    double b = double.Parse(lista[1]);
    double c = double.Parse(lista[2]);
    Console.WriteLine($"TRIANGULO: {(a*c)/2:0.000}");
    Console.WriteLine($"CIRCULO: {Math.Pow(c, 2) * (3.14159):0.000}");
    Console.WriteLine($"TRAPEZIO: {((a+b)*c)/2:0.000}");
    Console.WriteLine($"QUADRADO: {b*b:0.000}");
    Console.WriteLine($"RETANGULO: {a*b:0.000}");

    
  }
}