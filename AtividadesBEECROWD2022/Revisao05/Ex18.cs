using System;
class Programa{
  
  public static void Main(string[] args){
    Console.WriteLine("Digite um numero:");
    int a = int.Parse(Console.ReadLine());
    if (Primo(a) == true) Console.WriteLine("É primo"); 
    else Console.WriteLine("Não é primo");
  }
  public static bool Primo(int n){
    double n2 = Math.Sqrt(n)+1;
    int x = 2;
    bool prim = true;
    while(x<=n2){
      if (n%x == 0){
        prim = false;
        break;
      }
      x++;
    }
    return prim;
  }
  
}
