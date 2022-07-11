using System;
class Program{
  public static void Main(string[] args){

    Console.WriteLine("Digite uma frase: ");
    string[] frase = Console.ReadLine().Split(' ');
    int tam = frase.Length - 1;
    int t = 0;
    while (t <= tam){
  
      string palavra = frase[t];
      int i = palavra.Length - 1;
      string palavra_ao_contrario = "";
      while (i >= 0){
        palavra_ao_contrario += palavra[i];
        i--;
      }
      Console.WriteLine(palavra_ao_contrario);
      t++;
    }
    //Técnico em Informática para Internet
    
  }
}