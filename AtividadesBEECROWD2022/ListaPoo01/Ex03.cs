using System;
class margorP{
  public static void Main(string[] args){
    Console.WriteLine("Digite e distancia percorrida em km e as horas e minutos gastos,respectivamente, separados por espaço:");
    string[] informa = Console.ReadLine().Split();
    Viagem info = new Viagem();
    info.km = double.Parse(informa[0]);
    info.h = double.Parse(informa[1]);
    info.min = double.Parse(informa[2]);
    Console.WriteLine($"distancia percorrida foi de {info.km} km em um intevalo de tem de {info.h} horas e {info.min} minutos\nA velocidade media foi de {info.Vm():0.00} km/h");
  }
}
class Viagem{
  public double km, h, min;
  public double Vm(){
    return km/(h + min/60);
  }
}