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
    string teste = x.ToString();
    if (teste.IndexOf('.') != -1) return ((int)x);
    else if (x<0) return ((int)x+1);
    else return ((int)x) +1;  
    
  }
}
