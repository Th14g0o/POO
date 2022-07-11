using System;
class Program{
  public static void Main(string[] args){

    Console.WriteLine("Digite uma frase: ");
    string frase = Console.ReadLine().ToUpper();
    
    int a = 0;
    int e = 0;
    int i = 0;
    int o = 0;
    int u = 0;
    
    int te = 0;
    while (te <= frase.Length-1){
      switch(frase[te]){
        case 'A': a+=1; break;
        case 'E': e+=1; break;
        case 'I': i+=1; break;
        case 'O': o+=1; break;
        case 'U': u+=1; break;
        default: break;
      }
      te++;
    }
    Console.WriteLine($"A-{a}");
    Console.WriteLine("E-"+e);
    Console.WriteLine("I-{0}", i);
    Console.WriteLine($"O-{o}");
    Console.WriteLine("U-{0}", u);
    
    
  }
}