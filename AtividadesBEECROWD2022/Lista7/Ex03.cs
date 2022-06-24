using System;
class Classica {
  
  public static void Main(string[] args) {

    Console.WriteLine("Digite seu nome completo:");
    string nc = Console.ReadLine();
    Console.WriteLine($"Seu nome é {NomeInicial(nc)}, correto?");
    
  }

  public static string NomeInicial(string nome) {
    string[] ncd = nome.Split();
    return ncd[0];
  }
  
}