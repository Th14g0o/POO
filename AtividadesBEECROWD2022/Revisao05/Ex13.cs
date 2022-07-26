using System;
class Programa{
  
  public static void Main(string[] args){
    Console.WriteLine("Digite um texto: ");
    string texto = Console.ReadLine();
    if (texto == RemoverEspacos(texto)) Console.WriteLine("O texto não tem espaços desnecessarios");
    else Console.WriteLine("Por acaso não serie melhor: "+RemoverEspacos(texto));
  }
  
  public static string RemoverEspacos(string texto){
    string texto_formatado = "";
    bool espaco = false;
    foreach (char caracter in texto){
      if (caracter != ' '){
        string letra = caracter.ToString();
        texto_formatado += letra; 
        espaco = true;  
      }
      if (caracter == ' ' && espaco == true){ 
        texto_formatado += " ";
        espaco = false;
      }
    }
    if (texto_formatado[texto_formatado.Length-1] == ' ') return texto_formatado.Substring(0, texto_formatado.Length-1); //pega do 0 ate o penultimo caracter
    else return texto_formatado;
  }
}
