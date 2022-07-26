using System;
class Programa{
  public static void Main(string[] args){
    Console.WriteLine("Digite um numero:");
    double n = double.Parse(Console.ReadLine());
    Console.WriteLine($"[{n}] = "+ MenorInteiro(n));
  }
  // Math.Celing() menor inteiro, Math.Floor();
  public static int MenorInteiro(double x){
    //Função teto
    if (x<0) return ((int)x); 
    else return ((int)x) +1;  
    
  }
}
