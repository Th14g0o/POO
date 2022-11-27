using System;
class BeeCrowd{
  public static void Main(string[] args){
    
    string quant = Console.ReadLine();
    
    while ( String.IsNullOrEmpty(quant) != true){
      
      int[] vd = new int[31];
      int[] ve = new int[31];
      int pares = 0;
      for (int i = 0; i < int.Parse(quant); i++){
        string[] s = Console.ReadLine().Split();
        if (s[1].ToUpper() == "E") ve[(int.Parse(s[0])-30)] += 1;
        else vd[int.Parse(s[0])-30] += 1;
      }
      for (int i = 0; i < 31; i++){
        if (vd[i] > 0 && ve[i] > 0) pares += Math.Min(ve[i], vd[i]);
        
      }
      Console.WriteLine(pares);
      
      quant = Console.ReadLine(); 
      
    }
    
  }
}