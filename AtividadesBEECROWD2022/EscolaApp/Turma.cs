using System;
using System.Collections.Generic;//permite o uso de lista
using System.Xml.Serialization;//Classe que pega um objeto e passa para xml(arquivo de tag)
using System.IO; //reader e writer, lÊ e salva arquivos
class Progama{
  public static void Main(string[] args){
    Console.WriteLine("1-Inserir, 2-Listar, 3-Salvar, 4-Abrir, 0-Fim");
    int op = int.Parse(Console.ReadLine());
    while(op != 0){
      switch(op){
      case 1:
        Console.Write("Informe o Curso: ");
        string c = Console.ReadLine();
        Console.Write("Informe a Descrição: ");
        string d = Console.ReadLine();
        Console.Write("Informe o ID: ");
        int i = int.Parse(Console.ReadLine());
        Console.Write("Informe o ano letivo: ");
        int a = int.Parse(Console.ReadLine());
        Turma t = new Turma{Id = i, Curso = c, AnoLetivo = a, Descricao = d};
        NTurma.Inserir(t);
        break;
      case 2:
        foreach (Turma x in NTurma.Listar()){
          Console.WriteLine("° " + x);
        }
        break;
      case 3:
        NTurma.Salvar();
        break;
      case 4:
        NTurma.Abrir();
        break;
      }
      op = int.Parse(Console.ReadLine());
    }
  }
}


public class Turma{
  public int Id{get; set;}
  public string Curso{get;set;}
  public string Descricao{get; set;}
  public int AnoLetivo{get; set;}
  public override string ToString(){
    return $"{Id} - {Curso} - {Descricao} - {AnoLetivo}";
  }
}


//static permite armazernar apenas um, ou seja, so pode ser feito um objeto dessa classe. Ele cria automaticamente um objeto que ja pode ser utilizado com seus metodos(Se for criado um objeto ja vai dar erro)
static class NTurma{
  private static List<Turma> turmas = new List<Turma>();//aumenta conforme os elementos são adicionados
  public static void Inserir(Turma t){ // C - Create
    turmas.Add(t);
  }
  public static List<Turma> Listar(){ //R - Read
    return turmas;
  }
  public static void Atualizar(Turma t){ // U - Update
    
  }
  public static void Excluir(Turma t){ // D - Delete
  }
  public static void Abrir(){
    XmlSerializer xml = new XmlSerializer(typeof(List<Turma>));
    StreamReader f = new StreamReader("./RegistroAluno.xml");//carrega o arquivo
    turmas = (List<Turma>) xml.Deserialize(f); //converte o arquivo para lista de objetos turma
    f.Close();
  }
  public static void Salvar(){
    XmlSerializer xml = new XmlSerializer(typeof(List<Turma>)); //pega um objeto e passa para xml(arquivo de tag), a classe Turma precisa ser publica para o xml capturar suas informações
    StreamWriter f = new StreamWriter("./RegistroAluno.xml", false); //cria um arquivo
    xml.Serialize(f, turmas); //grava em f as informações de turmas
    f.Close();
  }
  
}