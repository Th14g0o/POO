using System;
class Program {
  public static void Main(string[] args) {  
    
    Console.WriteLine("Digite o primeiro horário no formato hh:mm");
    string[] ph = Console.ReadLine().Split(":");
    int phn1 = int.Parse(ph[0]);
    int phn2 = int.Parse(ph[1]);
  
    Console.WriteLine("Digite o segundo horário no formato hh:mm");
    string[] ph2 = Console.ReadLine().Split(":");
    int ph2n1 = int.Parse(ph2[0]);
    int ph2n2 = int.Parse(ph2[1]);

    int min = phn2 + ph2n2;
    int hora = (phn1 + ph2n1) + (min/60);
    int minutos = Math.Abs(((min/60) * 60 - min));
    
    Console.WriteLine($"Total de horas = {hora:00}:{minutos:00}");

  } 
}