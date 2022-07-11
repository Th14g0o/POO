using System;
class Program{
  public static void Main(string[] args){
    
    Console.WriteLine("Digite uma frase: ");
    string f = Console.ReadLine();
    
    int verifica = f.IndexOf(' ');
    
    while (verifica >= -1){
      
      if (verifica == -1) {
        Console.Write(f[f.Length - 1]);
        break;
      }
      else Console.Write(f.Substring(verifica - 1, 1));
      
      f = f.Substring(verifica + 1);
      
      verifica = f.IndexOf(' ');
    }
    Console.WriteLine();
  }
}
// Técnico em Informática para Internet