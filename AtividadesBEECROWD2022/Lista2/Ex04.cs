using System;
class Program{
  public static void Main(string[] args) {

    Console.WriteLine("Digite a base do retângulo:");
    double largura = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite a altura do retângulo:");
    double altura = double.Parse(Console.ReadLine());
    double perimetro = 2*(largura + altura);
    double area = largura * altura;
    double diagonal = Math.Sqrt((Math.Pow(largura, 2) + Math.Pow(altura, 2)));
    Console.WriteLine($"Área = {area:0.00}   Perimetro = {perimetro:0.00}   Diagonal = {diagonal:0.00}");
    
  }
}