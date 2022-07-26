using System;
class Programa{
  
  public static void Main(string[] args){
    Console.WriteLine("Digite seu nome:");
    string nome = Console.ReadLine();
    Console.WriteLine(Referencia(nome));
  }
  public static string Referencia(string nome){
    string[] nomes = nome.Split();
    string ultimo_nome = nomes[nomes.Length-1];
    string referencia = ultimo_nome+",";
    foreach (string palavra in nomes){
      string p = palavra;
      if (p == ultimo_nome) break;
      else p = p.ToUpper();
      switch(p){
        case "DA": p = p.ToLower(); break;
        case "DE": p = p.ToLower(); break;
        case "DO": p = p.ToLower(); break;
        case "DOS": p = p.ToLower(); break;
        case "DAS": p = p.ToLower(); break;
        default: referencia += " " + p[0].ToString() + "."; break;
      }
  
    }
    return referencia;  
  }
  
}
