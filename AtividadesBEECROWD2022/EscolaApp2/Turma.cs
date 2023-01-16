using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO; 
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


public class Turma
{
  public int Id { get; set; }
  public string Curso { get; set; }
  public string Descricao { get; set; }
  public int AnoLetivo { get; set; }
  public override string ToString()
  {
      return $"{Id} - {Curso} - {Descricao} - {AnoLetivo}";
  }
}
static class NTurma
{
    private static List<Turma> turmas = new List<Turma>();

    public static void Inserir(Turma t)
    {
        Abrir();
        turmas.Add(t);
        Salvar();
    }

    public static List<Turma> Listar()
    {
        Abrir();
        return turmas;
    }

    public static Turma IdT(int id)
    {
        foreach (Turma t in turmas)
            if (t.Id == id) return t;
        return null;
    }

    public static void Atualizar(Turma t)
    {
        Abrir();
        Turma obj = IdT(t.Id);
        obj.Curso = t.Curso;
        obj.Descricao = t.Descricao;
        obj.AnoLetivo = t.AnoLetivo;
        Salvar();

    }

    public static void Excluir(Turma t)
    {
        Abrir();
        turmas.Remove(IdT(t.Id));
        Salvar();
    }

    public static void Abrir()
    {
        StreamReader f = null;
        try 
        {
            XmlSerializer xml = new XmlSerializer(typeof(List<Turma>));
            f = new StreamReader("./TurmasRegistro.xml");
            turmas = (List<Turma>)xml.Deserialize(f);
        }
        catch
        {
            turmas = new List<Turma>();
        }
        if (f != null) f.Close();

    }

    public static void Salvar()
    {
        XmlSerializer xml = new XmlSerializer(typeof(List<Turma>));
        StreamWriter f = new StreamWriter("./TurmasRegistro.xml", false); 
        xml.Serialize(f, turmas); 
        f.Close();
    }
}