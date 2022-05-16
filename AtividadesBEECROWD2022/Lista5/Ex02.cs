using System;
class Program {
  public static void Main(string[] args) {
    
    string ns = Console.ReadLine();
    string[] Ns = ns.Split();
    int n1 = int.Parse(Ns[0]);
    int n2 = int.Parse(Ns[1]);
    
    if (n1 % n2 == 0 || n2 % n1 == 0){
      Console.WriteLine("Sao Multiplos");
    }
    else {
      Console.WriteLine("Nao sao Multiplos");
    } 
  }
}