using System;
class Program{
  public static void Main(string[] args){
    int N = int.Parse(Console.ReadLine());
    for (int at = 1; at <= N; at++){
      string[] ab = Console.ReadLine().Split();
      Console.WriteLine(MDC( int.Parse(ab[0]), int.Parse(ab[1])));  
    }  
  }

  public static int MDC(int a, int b){
    if (a % b == 0) return b;
    return MDC(b, a%b);
  
  }
  
}