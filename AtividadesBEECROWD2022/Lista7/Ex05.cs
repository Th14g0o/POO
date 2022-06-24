using System;
class SeilaMan {
  
  public static void Main(string[] args) {

    Console.WriteLine("Digite seu nome completo: ");
    string nc = Console.ReadLine();

    if (nc != FormatarNome(nc)) Console.WriteLine($"Ops, você quiz dizer {FormatarNome(nc)}?");
    else Console.WriteLine($"Bem vindo, {nc}.");
    
  }

  public static string FormatarNome(string nome){
    
    string[] dividido = nome.Split();
    int tamanho = dividido.GetUpperBound(0);
    string NomeFormat = "";
    for (int i = 0; i <= tamanho; i ++){

      string nomes = dividido[i];
      string inicial = (nomes[0].ToString()).ToUpper(); 
      string nome_format = nomes.Replace(nomes[0].ToString(), inicial);
      
      if (NomeFormat == "") NomeFormat += nome_format;
      else NomeFormat += " "+nome_format;
      
    }
    
    return NomeFormat;
    
  }
  
}
  
