using System;
class BeeCrowd{
  public static void Main(string[] args){
    double[,] matriz = new double[12, 12];
    
    //Console.WriteLine(matriz.Length); 144
    //Console.WriteLine(matriz.Rank); 2
    // int casa = 0;
    // int aumento = 1;
    // int quant = aumento;
    // int q = 1;
    // while(quant < 12){
      
    //   if (casa == 11) break;
      
    //   Console.WriteLine(matriz[quant, casa] + " quantidade de valores = " + q);
    //   quant++;
    //   q++;
      
    //   if (quant/12 >= 1){ 
    //     casa += 1; 
    //     aumento += 1; 
    //     quant = aumento;
    //   }
    // }
    string sm = Console.ReadLine();

    
    int casa = 0;
    int aumento = 0;
    int quant = aumento;
    while(quant < 12){
      
      if (casa == 11) break;
      
      double n = double.Parse(Console.ReadLine());
      matriz[quant, casa] = n;
      quant++;

      if (quant/12 >= 1){ 
        casa++; 
        quant = 0;
      }
      
    }
    
    double soma = 0;

    casa = 0;
    aumento = 1;
    quant = aumento;
    
    while(quant < 12){
      
      if (casa == 11) break;
      
      soma += matriz[quant, casa];
      quant++;
      
      if (quant/12 >= 1){ 
        casa += 1; 
        aumento += 1; 
        quant = aumento;
      }
    }

    
    if (sm.ToUpper() == "S") Console.WriteLine(soma);
    else Console.WriteLine($"{soma/66:0.0}");
      
  }
}