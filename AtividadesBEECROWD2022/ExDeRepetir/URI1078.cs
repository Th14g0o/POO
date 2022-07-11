using System;
class Program{
  public static void Main(string[] args){

    int n = int.Parse(Console.ReadLine());
    for (int q = 1; q<=10; q++) Console.WriteLine($"{q} x {n} = {n*q}");  
    
  }
}