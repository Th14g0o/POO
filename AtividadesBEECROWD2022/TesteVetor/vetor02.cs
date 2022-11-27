using System;
class Prog{
  public static void Main(string[] args){
    int[] v = {10, 4, 6, 3, 8, 12, 15, 20};
    
    foreach(int i in v)
      Console.WriteLine(i);
    
    for (int a = v.Length -1; a >= 0; a--)
      Console.WriteLine($"{a} - {v[a]}");
    Array.Sort(v);//organiza de modo crescente
    foreach(int i in v)
      Console.WriteLine(i);
    Console.WriteLine(Array.IndexOf(v, 20));//se o elemento não existitr retorna menos 1;
  }
}