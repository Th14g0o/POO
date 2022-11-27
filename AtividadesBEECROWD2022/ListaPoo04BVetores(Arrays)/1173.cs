using System;
class BeeCrowd{
  public static void Main(string[] args){
    int n = int.Parse(Console.ReadLine());
    for (int a = 0; a < 10; a++){
      Console.WriteLine($"N[{a}] = {n}");
      n = n * 2;
    } 
  }
}