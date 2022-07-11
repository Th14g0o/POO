using System;
class Program{
  public static void Main(string[] args){

    Console.WriteLine("Digite uma frase: ");
    string frase = Console.ReadLine();
    int t = 0;
    Console.WriteLine();
    while (t<= frase.Length - 1){
      frase = frase.Substring(1) + frase[0];
      Console.WriteLine(frase);
      t++;
    }
    // string frase_ao_contrario = "";
    // int t = frase.Length - 1;
    // while (t>=0){
    //   frase_ao_contrario += frase[t];
    //   t--;
    // }
    // Console.WriteLine(frase_ao_contrario);
    
    
    
  }
}