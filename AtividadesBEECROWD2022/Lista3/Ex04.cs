using System;
class Program{
  public static void Main(string[] argas) {

    string s = Console.ReadLine();
    string[] t = s.Split(' ');
    int a = int.Parse(t[0]);
    int b = int.Parse(t[1]);
    Console.WriteLine(a%b);
    
  }
}