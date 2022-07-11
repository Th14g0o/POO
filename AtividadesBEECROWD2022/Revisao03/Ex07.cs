using System;
class Program{
  public static void Main(string[] args){

    Console.WriteLine("Digite uma frase: ");
    string a = Console.ReadLine();
    Console.WriteLine(a);
    int p = a.IndexOf(' '); // devolve o indice do caracter escolhido que aparecer primeiro. Caso não exista devolve -1
    while (p != -1){
      a = a.Substring(p + 1);
      Console.WriteLine(a);
      p = a.IndexOf(' ');
    }
    
    
    
  }
}