using System;
class Programa{
  public static void Main(string[] args){
    Console.WriteLine("Digite a sua data de nascimento no formato \"dd/mm/aaaa\":");
    string data_n = Console.ReadLine();
    Console.WriteLine("Digite a data atual no formato \"dd/mm/aaaa\":");
    string data_a = Console.ReadLine();
    int a,m;
    Idade(data_a, data_n, out a, out m);
    Console.WriteLine($"sua idade é {a} anos e falta {m} meses para você completar {a+1} ");
  }
  public static void Idade(string hoje, string nascimento, out int anos, out int meses){
    string[] data_atual = hoje.Split('/');
    string[] data_nasci = nascimento.Split('/');
    anos = int.Parse(data_atual[2]) - int.Parse(data_nasci[2]);
    meses = int.Parse(data_atual[1]) - int.Parse(data_nasci[1]);
    if (meses < 0) meses = meses* (-1);
    if (meses != 0) anos = anos - 1; 
  }
  //31/12/2005
  //25/07/2022
}
