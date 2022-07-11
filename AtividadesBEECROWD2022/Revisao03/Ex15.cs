using System;
class Program{
  public static void Main(string[] args){

    Console.WriteLine("Digite uma frase: ");
    string[] frase = Console.ReadLine().Split();
    int t = 0;
    while (t <= frase.Length - 1){
      Console.Write(frase[t].Length );
      t++;
    }
    Console.WriteLine();
    //Técnico em Informática para Internet
    
    
  }
}