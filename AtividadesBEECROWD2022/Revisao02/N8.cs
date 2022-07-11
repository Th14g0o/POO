using System;
class Program {
  public static void Main(string[] args) {  

    Console.WriteLine("Digite quatro valores inteiros:");
    
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());
    int c = int.Parse(Console.ReadLine());
    int d = int.Parse(Console.ReadLine());

    int maior = a;
    int menor = a;

    if (maior <= b) maior = b;
    if (maior <= c) maior = c;
    if (maior <= d) maior = d;
    
    if (menor >= b) menor = b;
    if (menor >= c) menor = c;
    if (menor >= d) menor = d;

    int maior2 = 0;
    int menor2 = maior;

    if (maior2 <= a && a < maior) maior2 = a;
    if (maior2 <= b && b < maior) maior2 = b;
    if (maior2 <= c && c < maior) maior2 = c;
    if (maior2 <= d && d < maior) maior2 = d;

    if (menor2 >= a && a > menor) menor2 = a;
    if (menor2 >= b && b > menor) menor2 = b;
    if (menor2 >= c && c > menor) menor2 = c;
    if (menor2 >= d && d > menor) menor2 = d;
    
    int soma = maior2 + menor2;
    
    Console.WriteLine($"Maior valor = {maior} \nMenor valor = {menor} \nA soma do segundo maior valor com o segundo menor = {soma}");

  } 
}