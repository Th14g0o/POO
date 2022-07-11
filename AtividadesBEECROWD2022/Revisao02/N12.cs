using System;
class Program {
  public static void Main(string[] args) {  
    
    Console.WriteLine("Digite dois valores inteiros separados por um operador +, -, * ou / :");
    string conta = Console.ReadLine();
      
    string[] ab = conta.Split('+','-','/','*');
    int a = int.Parse(ab[0]);
    int b = int.Parse(ab[1]);

    int operando = conta.IndexOf('+'); //se for falso, retorna -1
    if (operando == -1) operando = conta.IndexOf('-');
    if (operando == -1) operando = conta.IndexOf('*');
    if (operando == -1) operando = conta.IndexOf('/');

    switch(conta[operando]) {
      case '+': Console.WriteLine($"O resultado da operação é {a+b}"); break;
      case '-': Console.WriteLine($"O resultado da operação é {a-b}"); break;
      case '/': Console.WriteLine($"O resultado da operação é {a/b}"); break;
      case '*': Console.WriteLine($"O resultado da operação é {a*b}"); break;
    }

  } 
}