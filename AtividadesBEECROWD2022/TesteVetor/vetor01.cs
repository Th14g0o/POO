using System;
class Programa{
  public static void Main(string[] args){
    int[] vetor = new int[4] {1, 2, 3, 4};
    Console.WriteLine($"{vetor[0]}\n{vetor[1]}\n{vetor[2]}\n{vetor[3]}");
    int[] w = {2, 3, 4, 5};
    Console.WriteLine(w[0]);
    int[] z = w;
    Console.WriteLine(w[0]);
    z[0] = 10;
    Console.WriteLine(w[0]);//printa 10 poruqe o z e w sao apenas referencia psra APENAS UM vetor.
    Console.WriteLine($"z = {w.Length} e w = {z.Length}");
    Console.WriteLine($"indica a dimensão de w: {w.Rank}");
    
    
    
  }
}