using System;
class Programa{
  public static void Main(string[] args){
    Console.WriteLine("Digite 2 numeros separados por espaço:");
    string[] ns = Console.ReadLine().Split();
    int n1 = int.Parse(ns[0]), n2 = int.Parse(ns[1]);
    Console.WriteLine("MMC = "+MMC(n1, n2));
  }
  public static int MMC(int x, int y){
    int a = Math.Max(x, y);
    while (a % x != 0 || a % y != 0) a++;
    return a;

  }
}
