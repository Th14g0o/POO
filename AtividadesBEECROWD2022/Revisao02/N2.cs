using System;
class Program {
  public static void Main(string[] args) {  
    Console.WriteLine("Digite 4 valores inteiros:");
      
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());
    int c = int.Parse(Console.ReadLine());
    int d = int.Parse(Console.ReadLine());
    
    int media = (a+b+c+d)/4;
      
    Console.WriteLine("Media = {0}", (a+b+c+d)/4);

    Console.WriteLine("Números menores que a média");
    if (media > a) {
      Console.WriteLine(a); 
    }  
    if (media > b) { 
      Console.WriteLine(b); 
    } 
    if (media > c) {
      Console.WriteLine(c);
    }
    if (media > d) { 
      Console.WriteLine(d);
    }

    Console.WriteLine("Números maiores que a média");
    if (media < a) {
      Console.WriteLine(a); 
    }  
    if (media < b) { 
      Console.WriteLine(b); 
    } 
    if (media < c) {
      Console.WriteLine(c);
    }
    if (media < d) { 
      Console.WriteLine(d);
    }
    

  } 
}