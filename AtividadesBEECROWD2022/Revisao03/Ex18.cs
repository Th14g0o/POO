using System;
class Program{
  public static void Main(string[] args){

    Console.WriteLine("Digite uma sequência de números separados por vírgula:");
    string[] ns = Console.ReadLine().Split(',');
    int t = 0;
    int soma = 0;
    while (t <= ns.Length - 1){
      soma += int.Parse(ns[t]); 
      t++;
    }
    Console.WriteLine("Soma = "+soma);
    //1,2,3,4,5
    
    
  }
}