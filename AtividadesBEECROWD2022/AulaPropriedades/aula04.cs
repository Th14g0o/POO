using System;
class FazendoProgramas{
  public static void Main(string[] args){

    Console.WriteLine("Exemplo 4");
    
    double b = double.Parse(Console.ReadLine());
    double h = double.Parse(Console.ReadLine());
    Triangulo t = new Triangulo(b, h);
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
  private double b, h;
  public Triangulo(double b, double h){
    if (b>0) this.b = b;
    if (h>0) this.h = h;
  }
  
  public double Base {
    get{
      return b;
    }
    set{
      if (value > 0) b = value;
    }
  }
  
  public double Altura {
    get => h;
    set => h = value > 0 ? value : 0; 
  }
  
  public double CalcArea {
    get{
      return b * h / 2;
    }
  }
  
  public override string ToString(){
    return $"Base = {b} | Altura = {h} | Area = {CalcArea}";
  }
  
}