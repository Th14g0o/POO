using System;
class Program{
  public static void Main(string[] args) {

    Console.WriteLine("Digite sua nota do primeiro bimestre:");
    int nota1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite sua nota do segundo bimestre:");
    int nota2 = int.Parse(Console.ReadLine());
    int peso1 = 2;
    int peso2 = 3;
    Console.WriteLine($"Media parcial = {((nota1*peso1) + (nota2*peso2))/(peso1 + peso2)}");
    
  }
}