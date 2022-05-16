using System;
class Program{
  public static void Main(string[] args) {
    
    string abc = Console.ReadLine();
    string[] ABC = abc.Split();
    double a = double.Parse(ABC[0]);
    double b = double.Parse(ABC[1]);
    double c = double.Parse(ABC[2]);
    
    double R1 = ((b*-1) + Math.Sqrt(((Math.Pow(b, 2)-(4*a*c)))))/(2*a);
    double R2 = ((b*-1) - Math.Sqrt(((Math.Pow(b, 2)-(4*a*c)))))/(2*a);
    
    if (((Math.Pow(b, 2) - (4*a*c))) < 0 || a <= 0) {
      Console.WriteLine("Impossivel calcular");
    }
    else {
      Console.WriteLine($"R1 = {R1:0.00000}");
      Console.WriteLine($"R2 = {R2:0.00000}");
    }  
  }
}
