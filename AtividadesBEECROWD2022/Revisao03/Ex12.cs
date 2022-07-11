using System;
class Program{
  public static void Main(string[] args){

    Console.WriteLine("Digite uma frase: ");
    string frase = Console.ReadLine();
    int fim_da_palavra = frase.IndexOf(' ');
    int cont = 0;
    while (fim_da_palavra >= -1){
      cont+=1;
      if (fim_da_palavra == -1) break;
      frase = frase.Substring(fim_da_palavra + 1);
      fim_da_palavra = frase.IndexOf(' ');
    }
    Console.WriteLine(cont);
    //Técnico em Informática para Internet
    
    
  }
}