using System;
class Program {
  public static void Main(string[] args) {  

    Console.WriteLine("Informe o número do mês:");
    int mes = int.Parse(Console.ReadLine());

    string[] meses = {"Janeiro", "Fevereiro", "Março", "Abril", "Maio",	"Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro"};
      
    if (mes == 1){
      Console.WriteLine($"O mês de {meses[0]} é do primeiro trimestre do ano");
    }
    if (mes == 2){
      Console.WriteLine($"O mês de {meses[1]} é do primeiro trimestre do ano");
    }
    if (mes == 3){
      Console.WriteLine($"O mês de {meses[2]} é do primeiro trimestre do ano");
    }
    if (mes == 4){
      Console.WriteLine($"O mês de {meses[3]} é do segundo trimestre do ano");
    }
    if (mes == 5){
      Console.WriteLine($"O mês de {meses[4]} é do segundo trimestre do ano");
    }
    if (mes == 6){
      Console.WriteLine($"O mês de {meses[5]} é do segundo trimestre do ano");
    }
    if (mes == 7){
      Console.WriteLine($"O mês de {meses[6]} é do terceiro trimestre do ano");
    }
    if (mes == 8){
      Console.WriteLine($"O mês de {meses[7]} é do terceiro trimestre do ano");
    }
    if (mes == 9){
      Console.WriteLine($"O mês de {meses[8]} é do terceiro trimestre do ano");
    }
    if (mes == 10){
      Console.WriteLine($"O mês de {meses[9]} é do quarto trimestre do ano");
    }
    if (mes == 11){
      Console.WriteLine($"O mês de {meses[10]} é do quarto trimestre do ano");
    }
    if (mes == 12){
      Console.WriteLine($"O mês de {meses[11]} é do quarto trimestre do ano");
    } 

  } 
}