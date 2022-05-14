using System;
class Program{
  public static void Main(string[] args) {

    Console.WriteLine("Digite seu nome completo:");
    string nome_completo = Console.ReadLine();
    string[] nomes = nome_completo.Split(' ');
    Console.WriteLine(nomes[0]);
    
  }
}