using System;
class Ploglam {
  
  public static void Main(string[] args) {

    Console.WriteLine("Digite suas duas notas separadas por espaço:");
    string[] notas = Console.ReadLine().Split();
    int nota1 = int.Parse(notas[0]);
    int nota2 = int.Parse(notas[1]);
    if (Media(nota1, nota2) == true) Console.WriteLine($"Aprovado, parabens!");
    else Console.WriteLine("Infelizmente você esta em prova final");
    
  }

  public static bool Media(int notaA, int notaB){
    double media = (notaA + notaB) / 2;
    if (media >= 60) return true;
    else return false;
  }

 
}