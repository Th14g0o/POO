using System;
class Programa{
  public static void Main(string[] args){
    Console.WriteLine("Digite a base e a altura, respectivamente, separadas por espaço: ");
    string[] ns = Console.ReadLine().Split();
    double b = double.Parse(ns[0]);
    double h = double.Parse(ns[1]);
    Console.WriteLine("O comprimento da diagonal é " + Diagonal(b, h));
  }
  public static double Diagonal(double b, double h){
    double d = Math.Sqrt(b*b + h*h);
    return d;
  }
}
