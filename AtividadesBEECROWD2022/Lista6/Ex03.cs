using System;
class Program {
  public static void Main(string[] args) {

    int x = int.Parse(Console.ReadLine());
    double somatotal = 0;
    double c = 0;
    double r = 0;
    double s = 0;
    for (int i = 1; i <= x; i++) {
      string[] aen = Console.ReadLine().Split();
      int n = int.Parse(aen[0]);
      somatotal += n;
      if (aen[1] == "C"){
        c += n;
      }
      if (aen[1] == "S"){
        s += n;
      }
      if (aen[1] == "R"){
        r += n;
      }
    }
    double pc = (c*100)/somatotal; 
    double pr = (r*100)/somatotal; 
    double ps = (s*100)/somatotal;
    Console.WriteLine($"Total: {somatotal:0.} cobaias");
    Console.WriteLine($"Total de coelhos: {c:0.}");
    Console.WriteLine($"Total de ratos: {r:0.}");
    Console.WriteLine($"Total de sapos: {s:0.}");
    Console.WriteLine($"Percentual de coelhos: {pc:0.00} %");
    Console.WriteLine($"Percentual de ratos: {pr:0.00} %");
    Console.WriteLine($"Percentual de sapos: {ps:0.00} %");
    
  }
}