using System;
class Program{
  public static void Main(string[] args){

    int n = 1;
    int multiplicador = 1;
    while (n <= 10){
      
      while (multiplicador <= 10){
        if (multiplicador == 1) Console.WriteLine("Tabuada de "+n);
        Console.WriteLine($"{n} x {multiplicador} = {n * multiplicador}");
        if (multiplicador == 10) Console.WriteLine();
        multiplicador++;
      }
      
      n++;
      multiplicador = 1;
    }
    
    
  }
}