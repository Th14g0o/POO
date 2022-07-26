using System;
class Programa{
  public static void Main(string[] args){
    Console.WriteLine("Digite o raio: ");
    double r = double.Parse(Console.ReadLine());
    Console.WriteLine("O volume da esfera, com Math.PI, é " + VolumeEsfera(r));
    Console.WriteLine("O volume da esfera, com PI aproximado, é " + VolumeEsferaAprox(r));
  }
  public static double VolumeEsfera(double raio){
    double v = (4*Math.Pow(raio, 3)*Math.PI)/3;
    return v;
  }
  public static double VolumeEsferaAprox(double raio){
    double v = (4*Math.Pow(raio, 3)*3.14)/3;
    return v;
  }
 
}