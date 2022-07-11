using System;
class Program{
  public static void Main(string[] args){
    // for (int i = 1; i<=10; i++){
    //   if (i%2 == 0) Console.WriteLine(i*-1);
    //   else Console.WriteLine(i);
    // }
    int i = 1;
    while (i<=10){
      if (i%2 == 0) Console.WriteLine(i*-1);
      else Console.WriteLine(i);
      i++;
    }
  }
}