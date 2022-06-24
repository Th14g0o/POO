using System;

class SoPraTestar {
  
  public static double MaiorABC(double a, double b, double c){

    double maior = a;
    if (b > maior) maior = b;
    else if (c > maior) maior = c;
    return maior;
    
  }
  
}
class Programa{
  
  public static void Main(string[] args) {
    Console.WriteLine("Escreva três numeros separados por espaço:");
    string[] abc = Console.ReadLine().Split();
    Console.WriteLine($"{SoPraTestar.MaiorABC(double.Parse(abc[0]), double.Parse(abc[1]), double.Parse(abc[2]))} é o maior!");
  }
  
 
    
}