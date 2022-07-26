using System;
class Programa{
  public static void Main(string[] args){
    Console.WriteLine("Digite a altura, largura e profundidade, respectivamente em litro, separados por um espaço: ");
    string[] ns = Console.ReadLine().Split();
    double h = double.Parse(ns[0]);
    double l = double.Parse(ns[1]);
    double p = double.Parse(ns[2]);
    Console.WriteLine("O volume em litros da caixa d ́água é " + VolumeLitros(h,l,p));
  }
  public static double VolumeLitros(double h, double l, double p){
    double v = h*l*p;
    return v;
  }
}
