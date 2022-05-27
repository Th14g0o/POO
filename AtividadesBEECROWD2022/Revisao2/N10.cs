using System;
class Program {
  public static void Main(string[] args) {  

    Console.WriteLine("Digite uma data no formato dd/mm/aaaa:");
    string[] dma = Console.ReadLine().Split("/");
    int dia = int.Parse(dma[0]);
    int mes = int.Parse(dma[1]);
    int ano = int.Parse(dma[2]);

    if (mes ==1 && dia >= 1 && dia <= 31 && ano >= 1900 && ano <= 2100) {
      Console.WriteLine("Data valida");
    }
    else if (mes ==2 && dia >= 1 && dia <= 28 && ano >= 1900 && ano <= 2100) {
      Console.WriteLine("Data valida"); 
    }
    else if (mes ==3 && dia >= 1 && dia <= 31 && ano >= 1900 && ano <= 2100) {
      Console.WriteLine("Data valida");
    }
    else if (mes ==4 && dia >= 1 && dia <= 30 && ano >= 1900 && ano <= 2100) {
      Console.WriteLine("Data valida");  
    }
    else if (mes ==5 && dia >= 1 && dia <= 31 && ano >= 1900 && ano <= 2100) {
      Console.WriteLine("Data valida");
    }
    if (mes ==6 && dia >= 1 && dia <= 30 && ano >= 1900 && ano <= 2100) {
      Console.WriteLine("Data valida");  
    }
    else if (mes ==7 && dia >= 1 && dia <= 31 && ano >= 1900 && ano <= 2100) {
      Console.WriteLine("Data valida");
    }
    else if (mes ==8 && dia >= 1 && dia <= 31 && ano >= 1900 && ano <= 2100) {
      Console.WriteLine("Data valida");  
    }
    else if (mes ==9 && dia >= 1 && dia <= 30 && ano >= 1900 && ano <= 2100) {
      Console.WriteLine("Data valida");
    }
    else if (mes ==10 && dia >= 1 && dia <= 31 && ano >= 1900 && ano <= 2100) {
      Console.WriteLine("Data valida"); 
    }
    else if (mes ==11 && dia >= 1 && dia <= 30 && ano >= 1900 && ano <= 2100) {
      Console.WriteLine("Data valida");
    }
    else if (mes ==12 && dia >= 1 && dia <= 31 && ano >= 1900 && ano <= 2100) {
      Console.WriteLine("Data valida"); 
    }
    else {
      Console.WriteLine("A data informada não é válida");
    }

  } 
}