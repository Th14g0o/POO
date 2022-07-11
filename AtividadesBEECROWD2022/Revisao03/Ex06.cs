using System;
class Program{
  public static void Main(string[] args){

    int soma = 1;
    Console.Write(1);
    // for (int m = 2; m<=30; m++){
    //   soma += m;
    //   if (m%3 != 0){
    //     Console.Write(" " + m);
    //   }
    //   else{
    //     Console.Write(" " + m);
    //     Console.Write(" " + soma);
    //     soma = 0;
    //   } 
    // }
    
    int m = 2;
    while (m<=30){
      soma+=m;
      if (m%3 != 0){
        Console.Write(" "+m);
      }
      else{
        Console.Write(" "+m);
        Console.Write(" "+soma);
        soma = 0;
      }
      m++;
      
    }
    Console.WriteLine();
    
    
  }
}