using System;
class llll{
  public static void Main(string[] args){
    Compra valores = new Compra();
    Console.WriteLine("Digiter o valor total em $:");
    valores.SetTotal(double.Parse(Console.ReadLine()));
    Console.WriteLine("Digiter o numero de prestações:");
    valores.SetNumPrestacoes(int.Parse(Console.ReadLine()));
    Console.WriteLine($"O valor total é R$ {valores.GetTotal():0.00} dividido em {valores.GetNumPrestacoes()} vez(es)\nValor da prestação = R$ {valores.GetValorPrestacao():0.00}\nValor total com desconto de 15% = R$ {valores.GetValorDesconto():0.00}");
  }
}
class Compra{
  private double total;
  private int numPrestacoes;

  public void SetTotal(double v){
    if (v > 0) total = v;
  }
  public double GetTotal(){
    return total;
  }
  public void SetNumPrestacoes(int a){
    if (a >= 0) numPrestacoes = a;
  }
  public int GetNumPrestacoes(){
    return numPrestacoes;
  }
  
  public double GetValorPrestacao(){
    return total/numPrestacoes;
  }
  public double GetValorDesconto(){
    return total - (total*15.00/100.00);
  }
}