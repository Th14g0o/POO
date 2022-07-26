using System;
class Programa{
  
  public static void Main(string[] args){
    Console.WriteLine("Digite \"c\" ou \"d\", para, respectivamente, crescetne ou decrescente: ");
    string cd = Console.ReadLine().ToLower();
    bool ordem;
    if (cd == "c") ordem = true;
    else ordem = false;
    Console.WriteLine("Digite tres numeros separados por espaço:");
    string[] ns = Console.ReadLine().Split();
    int n1 = int.Parse(ns[0]), n2 = int.Parse(ns[1]), n3 = int.Parse(ns[2]);
    Ordenar(ordem, ref n1, ref n2, ref n3);
    Console.WriteLine(n1+" "+n2+" "+n3);
  }
  public static void Ordenar(bool ordem, ref int a, ref int b, ref int c){
    int maior = a;
    int meio = b;
    int menor = c;
    
    if (b > maior) maior = b;
    if (c > maior) maior = c;
    
    if (a < menor) menor = a;
    if (b < menor) menor = b;
    
    if (a > menor && a < maior) meio = a;
    if (b > menor && b < maior) meio = b;
    if (c > menor && c < maior) meio = c;
    
    if (ordem == true) {
      a = menor; b = meio; c = maior;
    }
    else {
      c = menor; b = meio; a = maior;
    }
  }
}
