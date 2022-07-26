using System;
class Programa{
  public static void Main(string[] args){
    Console.WriteLine("Digite dois numeros separados por espaço:");
    string[] ns = Console.ReadLine().Split();
    int n1 = int.Parse(ns[0]);
    int n2 = int.Parse(ns[1]);
    Console.WriteLine(Soma(n1, n2));
  }
  public static int Soma(int inicio, int fim){
    int menor = inicio; int maior = fim;
    if (fim<menor){menor = fim; maior = inicio;}
    int soma = 0;
    for (int i = menor; i<=maior; i++) soma += i;
    return soma;
  }
}
