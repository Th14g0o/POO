using System;
class llll{
  public static void Main(string[] args){
    IMC info = new IMC();
    Console.WriteLine("Digite seu peso em kg:");
    info.SetPeso(double.Parse(Console.ReadLine()));
    Console.WriteLine("Digite sua altura em m:");
    info.SetAltura(double.Parse(Console.ReadLine()));
    Console.WriteLine($"Seu IMC, com {info.GetPeso()} kg e {info.GetAltura()} m, é {info.CalcIMC():0.00} kg/m²");
    
  }
}
class IMC{
  private double altura, peso;

  public void SetPeso(double p){
    if (p > 0) peso = p;
  }
  public double GetPeso(){
    return peso;
  }
  public void SetAltura(double a){
    if (a > 0) altura = a;
  }
  public double GetAltura(){
    return altura;
  }

  public double CalcIMC(){
    return peso/(altura*altura);
  }
}