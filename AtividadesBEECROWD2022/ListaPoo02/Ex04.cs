using System;
class Programa{
  public static void Main(string[] args){
    Entrada val = new Entrada();
    Console.WriteLine("Digite o dia(de seguda a sexta) e o horario(no formatto hh:mm:ss), respectivamente, separados por epaço:");
    string[] infos = Console.ReadLine().Split();
    val.SetDia(infos[0]);
    val.SetHor(infos[1]);
    Console.WriteLine("Digite 0 para meia entrada ou 1 para entrada inteira:");
    string m_ou_i = Console.ReadLine();
    if (m_ou_i == "0") Console.WriteLine($"A meia entrada em {val.GetDia()} as {val.GetHor()} horas vale R$ {val.EntradaMei():0.00}");
    else Console.WriteLine($"A entrada inteira em {val.GetDia()} as {val.GetHor()} horas vale R$ {val.EntradaInt():0.00}");
    
  }
}

class Entrada{
  private string dia;
  private int horario;
  
  public void SetDia(string d){
    string di = d.ToLower();
    if (di == "segunda" || di == "terça" || di == "quarta" || di == "quinta" || di == "sexta" || di == "sabado" || di == "domingo") dia = di;
  }
  public string GetDia(){
    return dia;
  }

  public void SetHor(string info){
    string[] hms = info.Split(':');
    int h = int.Parse(hms[0]);
    if (h >= 0) horario = h;
  }
  public int GetHor(){
    return horario;
  }

  public double EntradaInt(){
    double valor = 16;
    switch(dia){
      case "quarta": valor = 8; break;
      case "sexta":
      case "sabado":
      case "domingo": valor = 20; break;
    }
    
    if ((horario >= 17 || horario == 0) && dia != "quarta") valor = valor + (valor*(50.00/100.00));
    
    return valor;
    
  }
  
  public double EntradaMei(){
    if (dia == "quarta") return EntradaInt();
    else return EntradaInt()/2;
  }
}