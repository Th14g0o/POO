using System;
class ProgramaAe{
  public static void Main(string[] args){
    
    Console.WriteLine("Digite o nome da disciplina:");
    string ndd = Console.ReadLine();
    Console.WriteLine("Digite as notas 1, 2, 3 e a 4, respectivamente, separadas por espaço:");
    string[] ns = Console.ReadLine().Split();
    Disciplina x = new Disciplina();
    x.nome_da_disciplina = ndd;
    x.nota1 = double.Parse(ns[0]);
    x.nota2 = double.Parse(ns[1]);
    x.nota3 = double.Parse(ns[2]);
    x.nota4 = double.Parse(ns[3]);
    
    Console.WriteLine($"Disciplina: {x.nome_da_disciplina}");
    Console.WriteLine($"Nota 1 = {x.nota1}\nNota 2 = {x.nota2}\nNota 3 = {x.nota3}\nNota 4 = {x.nota4}");
    
    if (x.MediaParcial() < 60){
      Console.WriteLine("Digite a nota final");
      string nf = Console.ReadLine();
      x.provaf = double.Parse(nf);
      Console.WriteLine($"Nota da prova final = {x.provaf}");
    }
    else Console.WriteLine("Boa, não precisou de prova final");
    if (x.Aprovado() == true){ 
      Console.WriteLine("Aprovado");
      Console.WriteLine($"Media final = {x.MediaFinal()}");
    }
    else{
      Console.WriteLine("Reprovado");  
    }  
  }
}
class Disciplina{
  public string nome_da_disciplina;
  public double nota1, nota2, nota3, nota4, provaf;
  public double MediaParcial(){
    return (nota1*2+nota2*2+nota3*3+nota4*3)/10;
  }
  public double MediaFinal(){
    double mp = MediaParcial();
    if ( mp >= 60) return mp;
    return (mp+provaf)/2;
  }
  public bool Aprovado() {
    return MediaFinal() >= 60;
  }
}