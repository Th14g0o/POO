using System;
class Programa{
  public static void Main(string[] args){
    Console.WriteLine("Digite o raio do circulo:");
    double input1 = double.Parse(Console.ReadLine());
    Circulo c1 = new Circulo();
    c1.SetRaio(input1);
    // c1.SetRaio( double.Parse(Console.ReadLine()));
    Console.WriteLine($"Raio = {c1.GetRaio()}\nArea = {c1.CalcArea()}\nCircuferencia = {c1.CalcCirc()}");
  }
}
class Circulo{
  private double r;
  
  public void SetRaio(double valor){
    if (valor > 0) r = valor;
  }
  public double GetRaio(){
    return r;
  }
  
  public double CalcArea(){
    return r*r*Math.PI;
  }
  public double CalcCirc(){
    return r*2*Math.PI;
  }
}