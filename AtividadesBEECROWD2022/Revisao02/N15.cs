using System;
class Program {
  public static void Main(string[] args) {  
    
    Console.WriteLine("Digite 3 valores:");
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());
    int c = int.Parse(Console.ReadLine());

    int maior = a;
    int menor = a;
    int meio = a;

    if (maior <= b) maior = b;
    if (maior <= c) maior = c;
    
    if (menor >= b) menor = b;
    if (menor >= c) menor = c;

    if(maior <= meio && meio <= menor) meio = b;
    if(maior <= meio && meio <= menor) meio = c;

    Console.WriteLine($"{menor}, {meio}, {maior}");
    

  } 
}