using System;
class MetodoMain{
  public static void Main(string[] args){
    Console.WriteLine("Digite o horario, no formato hh:mm, e o dia, respectivamente, separados por espaço:");
    string[] info = Console.ReadLine().Split();
    Entrada marca = new Entrada();
    marca.horario = info[0];
    marca.dia = info[1];
    Console.WriteLine("Sua idade:");
    int idade = int.Parse(Console.ReadLine());
    Console.WriteLine($"{marca.dia} as {marca.horario}:00");
    if (idade > 17) Console.WriteLine($"Valor da entrada: R$ {marca.Inteira():0.00}");
    else Console.WriteLine($"Valor da meia entrada: R$ {marca.Meia():0.00}");
    
  }
}

class Entrada{
  public string horario,dia;
  
  public double Inteira(){
    int h = int.Parse(horario.Split(':')[0]);
    string d = dia.ToLower();
    double valor = 16;
    switch (d){
      case "quarta": valor = 8; break;
      case "sexta": 
      case "sabado": 
      case "domingo": valor = 20; break;
    }
    if (d != "quarta" && h > 17){
      return valor + ((valor*50)/100);
    }
    return valor;
    
  }
  
  public double Meia(){
    string d = dia.ToLower();
    if (d == "quarta") return 8;
    return Inteira()/2;
    // int h = int.Parse(horario.Split(':')[0]);
    // string d = dia.ToLower();
    // double valor = 8;
    // switch (d){
    //   case "sexta": 
    //   case "sabado": 
    //   case "domingo": valor = 10; break;
    // }
    // if (d != "quarta" && h > 17){
    //   return valor + ((valor*50)/100);
    // }
    // return valor;
    
  }
  
}