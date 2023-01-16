using System;
class FazendoProgramas{
  public static void Main(string[] args){

    Console.WriteLine("Exemplo 3");    
    
    double b = double.Parse(Console.ReadLine());
    double h = double.Parse(Console.ReadLine());
    Triangulo t = new Triangulo {Base = b, Altura = h};
    Console.WriteLine($"Base = {t.Base}");
    Console.WriteLine($"Altura = {t.Altura}");
    Console.WriteLine($"Area = {t.CalcArea}");
    Console.WriteLine($"Triangulo: {t}");
    
    b = double.Parse(Console.ReadLine());
    h = double.Parse(Console.ReadLine());
    t.Base = b;
    t.Altura = h;
    Console.WriteLine($"Base = {t.Base}");
    Console.WriteLine($"Altura = {t.Altura}");
    Console.WriteLine($"Area = {t.CalcArea}");
    Console.WriteLine($"Triangulo: {t}");

    
  }
}
class Triangulo{ 
  public double Base { get; set;}
  public double Altura { get; set;}
  public double CalcArea {
    get{
      return Base *Altura / 2;
    }
  } 
  public override string ToString(){
    return $"Base = {Base} | Altura = {Altura} | Area = {CalcArea}";
  }
  
}