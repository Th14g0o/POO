using System;
class Programa{
  public static void Main(string[] args){
    Console.WriteLine("Digite 1 numero:");
    int n = int.Parse(Console.ReadLine()), a, s;
    // int a; int s;
    AntecessorSucessor(n, out a, out s);
    Console.WriteLine($"Antecessor = {a}\nSucessor = {s}");
    
  }
  public static void AntecessorSucessor(int x, out int antecessor, out int sucessor){
    antecessor = x-1;
    sucessor = x+1;
  }
}
