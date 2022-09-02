using System;
class ProgramaMain{
  public static void Main(string[] args){
    Console.WriteLine("Digite o raio do circulo 1:");
    string a = Console.ReadLine();
    int n = 1;
    bool s = true;
    while (s==true){
      while (double.TryParse(a, out double x) == true){
        Circulo rc = new Circulo();
        rc.raio = double.Parse(a);
        Console.WriteLine($"Raio do Circulo {n} = {rc.raio}");
        Console.WriteLine($"A area deste circulo é {rc.Area():0.00}");
        Console.WriteLine($"A circunferencia deste circulo é {rc.Circ():0.00}");
        n++;
        Console.WriteLine("");
        Console.WriteLine($"Digite o raio do circulo {n}:");
        a = Console.ReadLine();
        
      }
      Console.WriteLine("");
      Console.WriteLine("");
      Console.WriteLine("Não é um numero real!");
      Console.WriteLine("Deseja tentar denovo? (digite abaixou s para sim ou n para não)");
      string sn = Console.ReadLine().ToLower();
      Console.WriteLine("");
      Console.WriteLine("");
      if (sn == "s"){
        Console.WriteLine($"Digite o raio do circulo {n}:");
        a = Console.ReadLine();
      }
      else s = false;
    }
  }
 
}
class Circulo{
  public double raio;
  public double Area(){
    return Math.Pow(raio,2) * Math.PI;
  }
  public double Circ(){
    return raio*2*Math.PI;
  }
}