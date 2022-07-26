using System;
class Programa{
  public static void Main(string[] args){
    Console.WriteLine("Digite a distancia percorrida, em km, e o tempo gasto, no formato \"hh:mm:ss\", respectivamente, separados por espaço: ");
    string[] dados = Console.ReadLine().Split();
    double distancia = double.Parse(dados[0]);
    string dt = dados[1];
    Console.WriteLine($"Velocidade Media = {VelocidadeMedia(distancia, dt)} km/h");
  }
  public static double VelocidadeMedia(double distancia, string tempo){
    string[] tempo_dividido = tempo.Split(':');
    int dt = int.Parse(tempo_dividido[0]) + (int.Parse(tempo_dividido[1])/60) + (int.Parse(tempo_dividido[02])/3600);
    double v = distancia/dt;
    return v;
    //5 2:0:0
  }
}
