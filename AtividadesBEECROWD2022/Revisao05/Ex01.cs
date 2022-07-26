using System;
class Programa{
  public static void Main(string[] args){
    Console.WriteLine("Digite 2 numeros separados por um espaço: ");
    string[] ns = Console.ReadLine().Split();
    double n1 = double.Parse(ns[0]);
    double n2 = double.Parse(ns[1]);
    Console.WriteLine("O menor numero é " + Menor(n1, n2));
  }
  public static double Menor(double x, double y){
    if (x<y) return x;
    else return y;
  }
  // public static double Menor(double x, double y){
  //   return Min(x,y);
  // }
   // public static double Menor(double x, double y){
  //   return x < y ? x : y;
  // }
}
