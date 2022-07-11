using System;
class Program {
  public static void Main(string[] args) {  

    Console.WriteLine("Digite uma data no formato dd/mm/aaaa:");
    
    string[] dma = Console.ReadLine().Split("/");
    
    int dia = int.Parse(dma[0]);
    int mes = int.Parse(dma[1]);
    int ano = int.Parse(dma[2]);

    string[] meses = {"Janeiro", "Fevereiro", "Março", "Abril", "Maio",	"Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro"};
      
    if (mes == 1){
      Console.WriteLine($"A data é {dia} de {meses[0]} de {ano}");
    }
    else if (mes == 2){
      Console.WriteLine($"A data é {dia} de {meses[1]} de {ano}");
    }
    else if (mes == 3){
      Console.WriteLine($"A data é {dia} de {meses[2]} de {ano}");
    }
    else if (mes == 4){
      Console.WriteLine($"A data é {dia} de {meses[3]} de {ano}");
    }
    else if (mes == 5){
      Console.WriteLine($"A data é {dia} de {meses[4]} de {ano}");
    }
    else if (mes == 6){
      Console.WriteLine($"A data é {dia} de {meses[5]} de {ano}");
    }
    else if (mes == 7){
      Console.WriteLine($"A data é {dia} de {meses[6]} de {ano}");
    }
    else if (mes == 8){
      Console.WriteLine($"A data é {dia} de {meses[7]} de {ano}");
    }
    else if (mes == 9){
      Console.WriteLine($"A data é {dia} de {meses[8]} de {ano}");
    }
    else if (mes == 10){
      Console.WriteLine($"A data é {dia} de {meses[9]} de {ano}");
    }
    else if (mes == 11){
      Console.WriteLine($"A data é {dia} de {meses[10]} de {ano}");
    }
    else if (mes == 12){
      Console.WriteLine($"A data é {dia} de {meses[11]} de {ano}");
    }
      

  } 
}