using System;
class Program{
  public static void Main(string[] args){

    string s = Console.ReadLine();
    while(string.IsNullOrEmpty(s) != true){
      int sn = int.Parse(s);
      string[] abc = Console.ReadLine().Split();  
      int a = int.Parse(abc[0]);
      int b = int.Parse(abc[1]);
      int c = int.Parse(abc[2]);
      Console.WriteLine(MMC(a, b, c) - sn);
      s = Console.ReadLine();
    }
  }
  public static int MMC(int a, int b, int c){
    int maior = a;
    if (b > maior) maior=b;
    if (c > maior) maior=c;
    while (!(maior % a == 0 && maior % b == 0 && maior % c == 0)) maior++;
    return maior;
  }
}