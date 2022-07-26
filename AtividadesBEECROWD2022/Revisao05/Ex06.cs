using System;
class Programa{
  public static void Main(string[] args){
    Console.WriteLine("Digite a massa em kg e a distancia em km, respectivamente, separados por um espaço: ");
    string[] ns = Console.ReadLine().Split();
    double m = double.Parse(ns[0]);
    double d = double.Parse(ns[1]);
    Console.WriteLine("O frete é " + Frete(m, d)+" R$");
  }
  public static double Frete(double massa, double distancia){
    double f = (massa/distancia)/100;
    return f;
  }
}
