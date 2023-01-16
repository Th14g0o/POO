using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;

class Progama{
  public static void Main(string[] args){
    
    Console.WriteLine("1 - Inserir\n2 - Listar\n3 - Salvar\n4 - Abrir\n0 - Finalizar");
    int escolha = int.Parse(Console.ReadLine());
    string n, m, e;
    int i, it;
    
    while (escolha != 0){
      
      switch(escolha){   
      case 1:
        Console.WriteLine("Digite o nome do aluno:");
        n = Console.ReadLine();
        Console.WriteLine("Digite a matricula do aluno:");
        m = Console.ReadLine();
        Console.WriteLine("Digite o email do aluno:");
        e = Console.ReadLine();
        Console.WriteLine("Digite o id do aluno:");
        i = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o id da turma do aluno:");
        it = int.Parse(Console.ReadLine());
        Aluno a = new Aluno{Id = i, Nome = n, Email = e, Matricula = m, IdTurma = it};
        NAluno.Inserir(a);
        break;
        
      case 2:
        Console.WriteLine("----------");
        foreach (Aluno al in NAluno.Listar()){
          Console.WriteLine(al);
        }
        Console.WriteLine("----------");
        break;
      case 3:
        NAluno.Salvar();
        break;
      case 4:
        NAluno.Abrir();
        break;
      }
      
      escolha = int.Parse(Console.ReadLine());
    }
    
  }
  
}


public class Aluno{
  
  public int Id{get; set;}
  public string Nome{get; set;}
  public string Matricula{get; set;}
  public string Email{get; set;}
  public int IdTurma{get; set;}
  
  public override string ToString(){
    return $"|{Id} - {Nome} - {Matricula} - {Email} - Turma: {IdTurma}";
  }
}


static class NAluno{
  
  private static List<Aluno> alunos = new List<Aluno>();
  
  public static void Inserir(Aluno a){
    alunos.Add(a);
  }
  
  public static List<Aluno> Listar(){
    return alunos;
  }
  
  public static void Salvar(){
    XmlSerializer xml = new XmlSerializer(typeof(List<Aluno>));
    StreamWriter f = new StreamWriter("./RegistroAluno.xml", false);
    xml.Serialize(f, alunos);
    f.Close();
  }
  
  public static void Abrir(){
    XmlSerializer xml = new XmlSerializer(typeof(List<Aluno>));
    StreamReader f = new StreamReader("./RegistroAluno.xml");
    alunos = (List<Aluno>) xml.Deserialize(f);
    f.Close();
  }
}