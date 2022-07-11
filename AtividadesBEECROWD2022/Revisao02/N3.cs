using System;
class Program {
  public static void Main(string[] args) {  
    Console.WriteLine("Digite 4 valores inteiros:");
      
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());
    int c = int.Parse(Console.ReadLine());
    int d = int.Parse(Console.ReadLine());

    int p = 0; int im = 0;

    if (a%2 == 0) p += a; 
    else im += a;
    
    if (b%2 == 0) p += b; 
    else im += b;
    
    if (c%2 == 0) p += c; 
    else im += c;
    
    if (d%2 == 0) p += d; 
    else im += d;

    Console.WriteLine("Soma dos valores pares = {0}", p);
    Console.WriteLine("Soma dos valores impares = {0}", im);
    

  } 
}