using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;

class Progama{
  public static void Main(string[] args){
    File.Delete("./TurmasRegistro.xml");
    File.Delete("./RegistroAluno.xml");
    Aluno a1 = new Aluno{ Id = 1, Nome = "Renan", Matricula = "1234", Email = "jhusdj|@."};
    Aluno a2 = new Aluno{ Id = 4, Nome = "Renan", Matricula = "1234", Email = "jhusdj|@."};
    Aluno a3 = new Aluno{ Id = 3, Nome = "Renan", Matricula = "1234", Email = "jhusdj|@."};
    Aluno a4 = new Aluno{ Id = 2, Nome = "Renan", Matricula = "1234", Email = "jhusdj|@."};
    NAluno.Inserir(a1);
    NAluno.Inserir(a2);
    NAluno.Inserir(a3);

    Turma t1 = new Turma{ Id = 1,  Curso = "Renan", AnoLetivo = 1234, Descricao = "jhusdj|@."};
    Turma t2 = new Turma{ Id = 4,  Curso = "Renan", AnoLetivo = 1234, Descricao = "jhusdj|@."};
    Turma t3 = new Turma{ Id = 3,  Curso = "Renan", AnoLetivo = 1234, Descricao = "jhusdj|@."};
    Turma t4 = new Turma{ Id = 2,  Curso = "Renan", AnoLetivo = 1234, Descricao = "jhusdj|@."};
    NTurma.Inserir(t1);
    NTurma.Inserir(t2);
    NAluno.Matricular(a1, t1);
    NAluno.Matricular(a2, t1);
    NAluno.Matricular(a3, t2);
    Console.WriteLine("Alunos da turma: " + t1);
    foreach (Aluno a in NAluno.Listar(t1))
      Console.WriteLine(" " + a);
     Console.WriteLine("Alunos da turma: " + t2);
    foreach (Aluno a in NAluno.Listar(t2))
      Console.WriteLine(" " + a);
     Console.WriteLine("Alunos: ");
    foreach (Aluno a in NAluno.Listar())
      Console.WriteLine(" " + a);
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

  public static void Matricular(Aluno a, Turma t){
    a.IdTurma = t.Id;
    Atualizar(a);
    
  }
  public static List<Aluno> Listar(Turma t){
    Abrir();
    List<Aluno> alunoz = new List<Aluno>();
    foreach(Aluno obj in alunos)
      if (obj.IdTurma == t.Id) alunoz.Add(obj);
    return alunoz;
  }
  public static void Inserir(Aluno a)
  {
      Abrir();
      alunos.Add(a);
      Salvar();
  }

  public static List<Aluno> Listar()
  {
      Abrir();
      return alunos;
  }
  public static void Exluir(Aluno a)
  {
      Abrir();
      alunos.Remove(Checar(a.Id));
      Salvar();
  }
  public static void Atualizar(Aluno a)
  {
      Abrir();
      Aluno obj = Checar(a.Id);
      if (obj!=null){
        obj.Matricula = a.Matricula;
        obj.IdTurma = a.IdTurma;
        obj.Email = a.Email;
        obj.Nome = a.Nome;
      }
      Salvar();
  }
  public static Aluno Checar(int a)
  {
      foreach (Aluno x in alunos)
          if (a == x.Id) return x;
      return null;

  }

  public static void Salvar()
  {
      XmlSerializer xml = new XmlSerializer(typeof(List<Aluno>));
      StreamWriter f = new StreamWriter("./RegistroAluno.xml", false);
      xml.Serialize(f, alunos);
      f.Close();
  }

  public static void Abrir()
  {
      StreamReader f = null;
      try
      {
          XmlSerializer xml = new XmlSerializer(typeof(List<Aluno>));
          f = new StreamReader("./RegistroAluno.xml");
          alunos = (List<Aluno>)xml.Deserialize(f);
      }
      catch
      {
          alunos = new List<Aluno>();
      }  
      if ( f!= null) f.Close();

  }

  
}



public class Turma
{
  public int Id { get; set; }
  public int IdProfessor { get; set; }
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

    public static void Cadastrar(Professor p, Turma t){
      Abrir();
      t.IdProfessor = p.Id;
      Atualizar(t);
    }
    public static List<Turma> Listar(Professor p){
      List<Turma> ts = new List<Turma>();
      foreach (Turma x in turmas)
        if (x.IdProfessor == p.Id) ts.Add(x);
      return ts;
          
    }
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
        if (obj!=null){
          obj.Curso = t.Curso;
          obj.Descricao = t.Descricao;
          obj.AnoLetivo = t.AnoLetivo;
          obj.IdProfessor = t.IdProfessor;
        }
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

public class Professor{
  public int Id{get; set;}
  public string Area{get; set;}
  public string Matricula{get; set;}
  public string Nome{get; set;}
  public override string ToString(){
    return $"{Nome} - {Id} - {Matricula} - {Area}";
  }
}
static class NProfessor{
  
  private static List<Professor> professores = new List<Professor>();
  public static void Abrir(){
    StreamReader f = null;
    try{
      XmlSerializer xml = new XmlSerializer(typeof(List<Professor>));
      f = new StreamReader("./RegistroProf.xml");
      professores = (List<Professor>)xml.Deserialize(f);
    }
    catch{
      professores = new List<Professor>();
    }
    if (f != null) f.Close();
  }
  public static void Salvar(){
    XmlSerializer xml = new XmlSerializer(typeof(List<Professor>));
    StreamWriter f = new StreamWriter("./RegistroProf.xml");
    xml.Serialize(f, professores);
    f.Close();
  } 
  public static void Inserir(Professor p){
    Abrir();
    professores.Add(p);
    Salvar();
  }
  public static List<Professor> Listar(){
    return professores;
  }
  public static Professor Checar(int p){
    foreach(Professor x in professores)
      if (x.Id == p) return x;
    return null;
  }
  public static void Excluir(Professor p){
    Abrir();
    professores.Remove(Checar(p.Id));
    Salvar();
  }
  public static void Atualizar(Professor p){
    Abrir();
    Professor s = Checar(p.Id);
    if (s!=null){
      s.Matricula = p.Matricula;
      s.Nome = p.Nome;
      s.Area = p.Area;
    }
    Salvar();
    
  }
  
}
