using System;
class Programa{
  public static void Main(string[] args){
    Console.WriteLine("Digite um texto:");
    string texto = Console.ReadLine();
    Console.WriteLine("Vogais: " + Vogais(texto));
  }
  // public static string Vogais(string s){
  //   int tam = s.Length - 1;
  //   string v = "";
  //   for (int i = 0; i <= tam; i++){
  //     string letra = s[i].ToString();
  //     switch(letra){
  //       case "a": v+=letra; break;
  //       case "A": v+=letra; break;
  //       case "e": v+=letra; break;
  //       case "E": v+=letra; break;
  //       case "i": v+=letra; break;
  //       case "I": v+=letra; break;
  //       case "o": v+=letra; break;
  //       case "O": v+=letra; break;
  //       case "u": v+=letra; break;
  //       case "U": v+=letra; break;
  //       default: break;  
  //     }
  //   }
  //   return v;
  // }
  public static string Vogais(string s){
    string v = "";
    foreach (char i in s){
      switch(i){
        case 'a': v+=i; break;
        case 'A': v+=i; break;
        case 'e': v+=i; break;
        case 'E': v+=i; break;
        case 'i': v+=i; break;
        case 'I': v+=i; break;
        case 'o': v+=i; break;
        case 'O': v+=i; break;
        case 'u': v+=i; break;
        case 'U': v+=i; break;
        default: break;  
      }
    }
    return v;
  }
  
}
