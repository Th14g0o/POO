using System;
class teste{
  public static void Main(string[] args){
    Bingo bolas = new Bingo();
    int quant = int.Parse(Console.ReadLine());
    bolas.Iniciar(quant);
    int ball = bolas.Proximo();
    for(int n = 0; n < bolas.Sorteados().Length; n++){
      Console.Write(bolas.Sorteados()[n] + " -");
    }
    Console.WriteLine("\n");
    if (ball == -1) Console.WriteLine("Acabo");
    
    
  }
}
class Bingo{
  private int numBolas, index;
  private int[] numeros;
  
  public void Iniciar(int numBolas){
    
    if (numBolas >= 10 && numBolas <= 100)
      this.numBolas = numBolas;
    else
      this.numBolas = 50;
    
    numeros = new int[numBolas];
    index = 0;
  }
  
  public int Proximo() {
    
    if (index == numBolas) return -1;
    Random r = new Random();
    int bola = r.Next(1, numBolas + 1);
    int posi = Array.IndexOf(numeros, bola);
    
    while(posi != -1){
      
      bola = r.Next(1, numBolas + 1);
      posi = Array.IndexOf(numeros, bola);
    }
    
    numeros[index] = bola;
    index++;
    return bola;
  }
  
  public int[] Sorteados(){
    
    int[] vetor = new int[index];
    Array.Copy(numeros, vetor, index);
    Array.Sort(vetor);
    return vetor;
    
  }
  
}