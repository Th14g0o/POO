using System;
class Program{
  public static void Main(string[] args){

    Console.WriteLine("Digite uma frase: ");
    string[] frase = Console.ReadLine().Split();
    
    int s = 0;
    
    int t = 0;
    int tp = 0;
    int v = 1;
    
    while (t <= frase.Length-1){
      string palavran = frase[t];
      string palavra = frase[t].ToUpper();
      
      while (tp <= palavra.Length - 1){
        switch(palavra[tp]){
          case 'A': s+=1; break;
          case 'E': s+=1; break;
          case 'I': s+=1; break;
          case 'O': s+=1; break;
          case 'U': s+=1; break;
          default: break;
        }
        tp++;
      }
      
      while (v <= s){
        Console.Write(palavran + " ");
        if (v == s){ 
          s = 0; 
          v = 0; 
          tp = 0;
        }
        
        v++;
      }
      
      t++;
    }
    Console.WriteLine();
    //Tecnico em Informatica para Internet
    
  }
}