using System;
class Program{
  
  public static void Main(string[] args){
    
    int t = 1;
    string ns = "";
    while (t <= 10){
      if (t % 2 == 0) ns += " " + t;
      if (t==1) Console.WriteLine("Resultado:    " + t + ns);
      else Console.WriteLine("              " + t + ns);
      t++;     
    }
   
  }
  
}