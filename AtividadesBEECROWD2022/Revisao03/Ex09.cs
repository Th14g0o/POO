using System;
class Program{
  public static void Main(string[] args){

    Console.WriteLine("Digite uma frase:");
    string palavra = Console.ReadLine();
    int tam = palavra.Length;
    int q = 1;
    while (q <= tam){
      Console.WriteLine(q+" - "+palavra);
      q++;
    }
    
    
  }
}