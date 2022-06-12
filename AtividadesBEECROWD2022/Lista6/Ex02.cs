using System;
class Program {
  public static void Main(string[] args) {

    int x = int.Parse(Console.ReadLine());
    int maior = x;
    int posi = 1;
    for (int y = 1; y <= 99; y++){
      int a = int.Parse(Console.ReadLine());
      if (a > maior) {
        maior = a;
        posi = y+1;
      } 
    }
    Console.WriteLine(maior);
    Console.WriteLine(posi);
    
  }
}