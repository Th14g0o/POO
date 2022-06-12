using System;
class Program {
  public static void Main(string[] args) {

    int quant = int.Parse(Console.ReadLine());
    int vezes = 1;
    while (vezes <= quant){
      string[] xy = Console.ReadLine().Split();
      double x = double.Parse(xy[0]);
      double y = double.Parse(xy[1]);
      if (y==0){
        Console.WriteLine("divisao impossivel");
      }
      else{
        Console.WriteLine($"{x/y:0.0}");
      }
      vezes+=1;
    }
    
  }
}