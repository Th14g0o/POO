using System;
class Program{
  public static void Main(string[] args){

    Console.WriteLine("Digite uma frase: ");
    string frase = Console.ReadLine();
    int t = frase.Length - 1;
    while (t>=0){
      Console.Write(frase[t]);
      t--;
    }
    Console.WriteLine();    
    
  }
}