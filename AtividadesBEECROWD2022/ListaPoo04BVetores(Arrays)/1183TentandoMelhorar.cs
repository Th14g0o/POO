using System;
class BeeCrowd{
  public static void Main(string[] args){
    
    double[,] matriz = new double[12, 12];
    string sm = Console.ReadLine();
    
    for (int i = 0; i < 12; i++){
      for (int y = 0; y < 12; y++){
        double n = double.Parse(Console.ReadLine());
        matriz[y, i] = n;
      }
    }
    
    double soma = 0;  
    for (int i = 0; i < 12; i++){
      for (int y = i+1; y < 12; y++){
        soma += matriz[y, i];
      }
    }
    
    if (sm.ToUpper() == "S") Console.WriteLine(soma);
    else Console.WriteLine($"{soma/66:0.0}");
    
  }
}