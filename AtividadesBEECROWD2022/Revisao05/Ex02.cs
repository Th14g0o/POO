using System;
class Programa{
  public static void Main(string[] args){
    Console.WriteLine("Digite o raio: ");
    double r = double.Parse(Console.ReadLine());
    Console.WriteLine("A area desse circulo com Math.PI é " + AreaDoCirculo(r));
    Console.WriteLine("A area desse circulo com PI arredondado é " + AreaDoCirculoAprox(r));
  }
  public static double AreaDoCirculo(double raio){
    double a = (raio*raio)*Math.PI;
    return a;
  }
  public static double AreaDoCirculoAprox(double raio){
    double a = (raio*raio)*3.14;
    return a;
  }
}
