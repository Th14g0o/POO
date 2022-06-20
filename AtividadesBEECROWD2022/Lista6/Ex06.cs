using System;
class Program {
  public static void Main(string[] args) {

    int quant_termos = int.Parse(Console.ReadLine());
    int vezes = 1;
    int an1 = 0;
    int an2 = 1;
    Console.Write("0");
    if (quant_termos > 1) {
      while (vezes <= quant_termos-1) {
        int term = an2 + an1;
        an2 = an1;
        an1 = term;
        Console.Write(" "+term.ToString());
        vezes ++;
      }
    } 
    Console.WriteLine();
    
  }
}