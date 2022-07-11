using System;
class Program{
  public static void Main(string[] args){

    int n = 1;
    Console.Write(n);
    // for (int q = 1; q<=9; q++){
    //   Console.Write(" " + (q + n));
    //   n = q+n;
    // }
    int q = 1;
    while (q<=9){
      Console.Write(" " + (q + n));
      n = q+n;
      q++;
      
    }
    Console.WriteLine();
    
    
  }
}