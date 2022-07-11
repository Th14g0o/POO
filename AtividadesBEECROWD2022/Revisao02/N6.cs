using System;
class Program {
  public static void Main(string[] args) {  

    Console.WriteLine("Digite três valores inteiros:");
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());
    int c = int.Parse(Console.ReadLine());

    int maior = a;
    int menor = a;

    if (maior <= b) maior = b;
    if (maior <= c) maior = c;
    
    if (menor >= b) menor = b;
    if (menor >= c) menor = c;

    int soma = maior + menor;
    Console.WriteLine($"A soma do maior com o menor número é {soma}");
    
  } 
}