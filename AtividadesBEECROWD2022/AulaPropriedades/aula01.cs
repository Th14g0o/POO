using System;
class FazendoProgramas{
  public static void Main(string[] args){

    Console.WriteLine("Exemplo 1");
  
    double b = double.Parse(Console.ReadLine());
    double h = double.Parse(Console.ReadLine());
    Triangulo t = new Triangulo(b, h);
    Console.WriteLine($"Base = {t.GetBase()}");
    Console.WriteLine($"Altura = {t.GetAltura()}");
    Console.WriteLine($"Area = {t.CalcArea()}");
    Console.WriteLine($"Triangulo: {t}");
    
    b = double.Parse(Console.ReadLine());
    h = double.Parse(Console.ReadLine());
    t.SetBase(b);
    t.SetAltura(h);
    Console.WriteLine($"Base = {t.GetBase()}");
    Console.WriteLine($"Altura = {t.GetAltura()}");
    Console.WriteLine($"Area = {t.CalcArea()}");
    Console.WriteLine($"Triangulo: {t}");

    
  }
}
class Triangulo{
  private double b, h;
  
  public Triangulo(double b, double h){
    if (b>0) this.b = b;
    if (h>0) this.h = h;
  }
  
  public void SetBase(double v){
    if (v>0) b = v;
  }
  
  public double GetBase(){
    return b;
  }
  
  public void SetAltura(double v){
    if (v>0) h = v;
  }
  
  public double GetAltura(){
    return h;
  }
  
  public double CalcArea(){
    return b * h / 2;
  }
  
  public override string ToString(){
    return $"Base = {b} | Altura = {h} | Area = {CalcArea()}";
  }
  
}