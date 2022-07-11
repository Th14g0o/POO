using System;
class SeilaMan {
  
  public static void Main(string[] args) {

    Console.WriteLine("Digite seu nome completo: ");
    string nc = Console.ReadLine();

    // if (nc != FormatarNome(nc)) Console.WriteLine($"Ops, você quis dizer {FormatarNome(nc)}?");
    // else Console.WriteLine($"Bem vindo, {nc}.");

    if (nc != FormatarNomeProf(nc)) Console.WriteLine($"Ops, você quis dizer {FormatarNomeProf(nc)}?");
    else Console.WriteLine($"Bem vindo, {nc}.");
    
  }

  // public static string FormatarNome(string nome){
    
  //   string[] dividido = nome.Split();
  //   int tamanho = dividido.GetUpperBound(0);
  //   // int tamanho = dividido.Length;
  //   string NomeFormat = "";
  //   for (int i = 0; i <= tamanho; i ++){

  //     string nomes = dividido[i];
  //     string nomesstr = nomes.ToString();
  //     string inicial = (nomesstr[0].ToString()).ToUpper(); 
  //     string removinical = nomesstr.Remove(0, 1);
  //     string nome_format = inicial + (removinical.ToLower());
  //     // string nome_format = nomes.Replace(nomes[0].ToString(), inicial);
      
  //     if (NomeFormat == "") NomeFormat += nome_format;
  //     else NomeFormat += " "+nome_format;
      
  //   }

  //   return NomeFormat;
    
  // }
    
  public static string FormatarNomeProf(string nome){
    
    string[] dividido = nome.ToLower().Split();
    string nomeformat = "";
    foreach (string n in dividido) {
      switch (n) {
        case "das":
        case "dos":
        case "da":
        case "de":
        case "do":
        case "e": nomeformat += n + " "; break;
        case "i": nomeformat += "I "; break;
        case "ii": nomeformat += "II "; break;
        case "iii": nomeformat += "III "; break;
        case "iv": nomeformat += "IV "; break;
        case "v": nomeformat += "V "; break;
        case "vi": nomeformat += "VI "; break;   
        default:
          if (n != "") nomeformat += n.Substring(0, 1).ToUpper() + n.Substring(1) + " "; break;
      }
    
      //Console.WriteLine(n[0]) #devolve um caracter
      //Console.WriteLine(n.Substring(0,1)) #serve para pegar uma letra, 0=inicio; 1  quantidade
      //Console.WriteLine(n.Substring(1)) #serve para pegar todas as letras a partir da colocada, onde, 1=inicio e quantidade=todo resto apartir do inicio
      
    }
    
    return nomeformat.Remove(nomeformat.Length - 1, 1);
    
  } 
  
}
  
