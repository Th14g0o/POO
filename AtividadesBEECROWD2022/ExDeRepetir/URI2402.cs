using System;
class Program{
  public static void Main(string[] args){

    long qds = long.Parse(Console.ReadLine());
    string nous = "N";
    for (int i = 2; i <= Math.Sqrt(qds); i++ ){
      if (qds % i == 0 && qds != 2){
        nous = "S";
        break;
      }
    }
    if (qds == 2) nous = "S";
    Console.WriteLine(nous);
    
  }
}