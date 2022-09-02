using System;
class Programa{
  public static void Main(string[] args){
    Viagem info = new Viagem();
    Console.WriteLine("Digite a distancia percorrida em km e o tempo(no formato HH:MM), respectivamente");
    string[] infos = Console.ReadLine().Split();
    info.SetDist(double.Parse(infos[0]));
    info.SetTemp(infos[1]);
    Console.WriteLine($"Com {info.GetDist()} km percorridos em {info.GetTemp()} horas se possui uma velocidade media de {info.VelocidadeMedia()} km/h");
  }
}
class Viagem{
  private double distancia, tempo;
  
  public void SetDist(double d){
    if (d >= 0) distancia = d;
  } 
  public double GetDist(){
    return distancia;
  }

  public void SetTemp(string hm){
    string[] hhmm = hm.Split(':');
    double h = double.Parse(hhmm[0]);
    double m = double.Parse(hhmm[1]);
    if (h >= 0 && m >= 0) tempo = h + (m/60);
  }
  public double GetTemp(){
    return tempo;
  }

  public double VelocidadeMedia(){
    return distancia/tempo;
  }
  
}