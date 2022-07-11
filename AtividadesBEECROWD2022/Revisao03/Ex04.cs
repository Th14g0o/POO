using System;
class Program{
  public static void Main(string[] args){
    // for (int i = 1; i<=30; i++){
    //   if (i%3 == 0) Console.WriteLine(i*-1);
    //   else Console.WriteLine(i);
    // }
    int i = 1;
    while (i<=30){
      if (i%3 == 0) Console.WriteLine(i*-1);
      else Console.WriteLine(i);
      i++;
    }
    
  }
}