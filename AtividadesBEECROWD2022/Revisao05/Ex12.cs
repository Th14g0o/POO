using System;
class Programa{
  public static void Main(string[] args){
    Console.WriteLine("Digite um texto: ");
    string texto = Console.ReadLine();
    Console.WriteLine(Senha(texto));
  }
  public static string Senha(string texto){
    string[] palavras = texto.Split();
    int tam = palavras.Length-1;
    string senha = "";
    for (int i = 0; i<= tam; i++){
      string palavra = palavras[i];
      int a = palavra.Length;
      senha+=a;
    }
    return senha;
  }
}
