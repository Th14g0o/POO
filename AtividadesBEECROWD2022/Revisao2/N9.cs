using System;
class Program {
  public static void Main(string[] args) {  
    
    Console.WriteLine("Digite o horário no formato hh:mm");
    string[] ph = Console.ReadLine().Split(":");
    int phn1 = int.Parse(ph[0]);
    int phn2 = int.Parse(ph[1]);

    int angulo = Math.Abs(((phn2*11) - (phn1*60))/2);
    
    if (phn2 < 0 ||phn2 > 60 || phn1 < 1 || phn1 > 12 ) {
      Console.WriteLine("Hora Inválida");
    }
    else {
      Console.WriteLine($"Menor ângulo entre os ponteiros = {angulo} graus");
    }

    
   


  } 
}