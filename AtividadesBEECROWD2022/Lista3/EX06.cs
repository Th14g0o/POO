using System;
class Program{
  public static void Main(string[] argas) {

    string Ns = Console.ReadLine();
    string[] NumerosStr = Ns.Split();
    int T1 = int.Parse(NumerosStr[0]);
    int T2 = int.Parse(NumerosStr[1]);
    int T3 = int.Parse(NumerosStr[2]);
    int T4 = int.Parse(NumerosStr[3]);
    Console.WriteLine(((T1+T2+T3+T4)-3));
    
  }
}