using System;
class Programa{
  public static void Main(string[] args){
    Console.WriteLine("Digite um texto e a posição da palavra desejada, respectivamente: ");
    string texto = Console.ReadLine();
    int pos = int.Parse(Console.ReadLine());
    Console.WriteLine(Palavra(texto, pos));
  }
  public static string Palavra(string texto, int pos){
    int posi = texto.IndexOf(' ');
    string palavra = "";
 
    for (int i = 1 ; i<=pos; i++){
      texto = texto.Substring(posi+1);
      posi = texto.IndexOf(' ');
    }
    if (texto.IndexOf(' ') == -1) return palavra = texto.Substring(0);
    else return palavra = texto.Substring(0, texto.IndexOf(' '));
  }
}
