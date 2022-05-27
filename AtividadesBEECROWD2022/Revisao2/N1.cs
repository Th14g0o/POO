using System;
class Program {
  public static void Main(string[] args) {  
    
    Console.WriteLine("Digite 2 valores inteiros:");
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());
    
    if (a > b) Console.WriteLine("Maior = {0}", a);
    if (b > a) Console.WriteLine("Maior = {0}", b);
    if (a == b) Console.WriteLine("São Iguais");

  } 
}