using System;
class Program {
  public static void Main(string[] args) {
    
    string ns = Console.ReadLine();
    string[] Ns = ns.Split();
    int a = int.Parse(Ns[0]);
    int b = int.Parse(Ns[1]);
    if (a < 0 || b < 0 || a > 432 || b > 468) {
      Console.WriteLine("fora");
    }
    else {
      Console.WriteLine("dentro");
    }
    
  }
}