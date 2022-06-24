using System;
class Programa{
  
  public static void Main(string[] args) {
    Console.WriteLine("Escreva dois numeros separados por espaço:");
    string[] ab = Console.ReadLine().Split();
    Console.WriteLine($"{MaiorAB(double.Parse(ab[0]), double.Parse(ab[1]))} é o maior!");
  }
  
  public static double MaiorAB(double a, double b){
    if (a>b) return a;
    else return b;
  }
    
}
