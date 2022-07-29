using System;
class Programa{
  public static void Main(string[] args){
    Console.WriteLine("Digite a distancia percorrida, em km, e o tempo gasto, no formato \"hh:mm:ss\", respectivamente, separados por espaço: ");
    string[] dados = Console.ReadLine().Split();
    double distancia = double.Parse(dados[0]);
    string dt = dados[1];
    Console.WriteLine($"Velocidade Media = {VelocidadeMedia(distancia, dt):0.00} km/h");
  }
  public static double VelocidadeMedia(double distancia, string tempo){
    string[] tempo_dividido = tempo.Split(':');
    double dt = double.Parse(tempo_dividido[0]) + (double.Parse(tempo_dividido[1])/60) + (double.Parse(tempo_dividido[02])/3600);
    double v = distancia/dt;
    return v;
    //10 1:40:60
  }
}
