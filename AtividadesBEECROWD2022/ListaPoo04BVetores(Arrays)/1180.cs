using System;
class BeeCrowd{
   public static void Main(string[] args){

      int quant = int.Parse(Console.ReadLine());
      int[] v = new int[quant];
      string[] ns = Console.ReadLine().Split();

      for (int i = 0; i < quant; i++){
         v[i] = int.Parse(ns[i]);
      }

      int menor = v[0];
      int posi = 0;

      for (int i = 0; i < quant; i++){
         if (v[i] < menor){ 
            menor = v[i];
           posi = i;
         }
      }
      Console.WriteLine($"Menor valor: {menor}\nPosicao: {posi}");


   }
}