using System;
class ListaPoo04{
  public static void Main(string[] args){

    // Cliente client = new Cliente("Thiago","192371",10.5);
    // Cliente socio = new Cliente("Ghu","6474",10.5);
    // client.SetSocio(socio);
    // Empresa JogosDoThiago = new Empresa();
    // JogosDoThiago.Inserir(client);
    // int cont = 1;
    // foreach(Cliente cli in JogosDoThiago.Listar()){
    //   Console.WriteLine($"Cliente {cont}:");
    //   Console.WriteLine(cli);
    //   Console.WriteLine($"Limite idividual: {cli.GetLimite()}");     
    // }  
    
    Console.WriteLine("Digite o seu limite de credito:");
    double l = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite o seu CPF:");
    string c = Console.ReadLine();
    Console.WriteLine("Digite o seu nome:");
    string n = Console.ReadLine();

    Cliente client = new Cliente(n,c,l);

    Console.WriteLine("Você Possui um socio?(\"s\" para sim ou \"n\" para não)");
    string sn = Console.ReadLine();
    
    if (sn[0].ToString().ToLower() == "s"){
      Console.WriteLine("Digite o limite de credito do seu socio:");
      double ls = double.Parse(Console.ReadLine());
      Console.WriteLine("Digite o CPF do seu socio:");
      string cs = Console.ReadLine();
      Console.WriteLine("Digite o nome do seu socio:");
      string ns = Console.ReadLine();
      Cliente socio = new Cliente(ns,cs,ls);
      client.SetSocio(socio);
    }
    
    Empresa JogosDoThiago = new Empresa();
    
    JogosDoThiago.Inserir(client);
    
    int cont = 1;
    
    Console.WriteLine("________________________");
    
    foreach(Cliente cli in JogosDoThiago.Listar()){
      
      Console.WriteLine($"Cliente {cont}:");
      Console.WriteLine(cli);
      Console.WriteLine($"Limite Total: {cli.GetLimite()}");      
      cont++;
      
    }  
    
    Console.WriteLine("________________________");
    
    
  }
}


class Cliente{
  
  private string nome, cpf;
  private Cliente socio;
  private double limite;
  
  public Cliente(string nome, string cpf, double limite){
    this.nome = nome;
    this.cpf = cpf;
    this.limite = limite;
  }

  public void SetSocio(Cliente c){
    socio = c;
  }
  public double GetLimite(){
    if (socio != null)
      return limite + this.socio.GetLimite();
    else
      return limite;
  }
  public override string ToString(){
    return $"Nome: {this.nome}\nCPF: {this.cpf}\nLimite individual: {this.limite}";
  }
  
}


class Empresa{
  
  private Cliente[] clientes = new Cliente[10];
  private int cont = 0;

  public void Inserir(Cliente c){
    if (cont == clientes.Length) 
      Array.Resize(ref clientes, clientes.Length * 2);
    clientes[cont] = c;
    cont++; 
  }
  public Cliente[] Listar(){
    Cliente[] vetor = new Cliente[cont];
    Array.Copy(clientes, vetor, cont);
    return vetor;
  }
  
}