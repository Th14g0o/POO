using System;
class BeeCrowd{
  public static void Main(string[] args){
    int[] x = new int[10];
    for (int y = 0; y < 10; y++){
      int n = int.Parse(Console.ReadLine());
      if (n <= 0) x[y] = 1;
      else x[y] = n;
    }
    for (int i = 0; i < 10; i++){
      Console.WriteLine($"X[{i}] = {x[i]}");
    }
  }
}