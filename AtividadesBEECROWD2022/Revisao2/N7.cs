using System;
class Program {
  public static void Main(string[] args) {  

    Console.WriteLine("Digite os coeficientes a, b, e c de uma equação do II grau");
    double a = double.Parse(Console.ReadLine());
    double b = double.Parse(Console.ReadLine());
    double c = double.Parse(Console.ReadLine());

    double x1 = ((b*-1) + Math.Sqrt((Math.Pow(b, 2) - (4*a*c))))/(2*a);
    double x2 = ((b*-1) - Math.Sqrt((Math.Pow(b, 2) - (4*a*c))))/(2*a);

    if (a < 0 || Math.Sqrt((Math.Pow(b, 2) - (4*a*c))) > 0) {
      Console.WriteLine("impossível calcular.");
    }
    else{
      Console.WriteLine($"As raízes são {x1} e {x2}");
    }
  } 
}