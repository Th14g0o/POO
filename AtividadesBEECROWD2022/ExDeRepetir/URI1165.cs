using System;
class Program{
  public static void Main(string[] args){

    int qn = int.Parse(Console.ReadLine());
    string primo = "";
    
    for (int q = 1; q <= qn; q++) {
      int n = int.Parse(Console.ReadLine());
      if (n==2) primo = "eh primo";  
      else{
        for (int d = (n-1); d > 1; d--){
          if (n%d == 0){ 
            primo = "nao eh primo";
            break;
          }
          else {primo = "eh primo";}   
        }
      }
      Console.WriteLine(n + " " + primo);
    }
    
  }
}