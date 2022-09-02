using System;
class Prkdsifdaf{
  public static void Main(string[] args){
    Disciplina materia = new Disciplina();
    Console.WriteLine("Digite o nome da disciplina:");
    materia.SetNome(Console.ReadLine());
    Console.WriteLine("Digite a nota 1, nota 2, nota 3 e nota 4, respectivamente, separadas por espaço: ");
    string[] nms = Console.ReadLine().Split();
    materia.SetNota1(int.Parse(nms[0]));
    materia.SetNota2(int.Parse(nms[1]));
    materia.SetNota3(int.Parse(nms[2]));
    materia.SetNota4(int.Parse(nms[3]));
    Console.WriteLine($"Na disciplina {materia.GetNome()}:\nSuas notas foram {materia.GetNota1()}, {materia.GetNota2()}, {materia.GetNota3()} e {materia.GetNota4()}");
    if (materia.Aprov() == true){
      Console.WriteLine($"Parabens! Passou por media com: {materia.CalcMediaParcial()}");
    }
    else{
      Console.WriteLine("Infelimente, não passou por media, mas, se possuir a nota da prova final, digite-a:");
      materia.SetNotaf(int.Parse(Console.ReadLine()));
      if (materia.AprovF() == true){
        Console.WriteLine($"Boa! Passou!\nSua media final foi {materia.CalcMediaFinal()} com a nota da prova final sendo {materia.GetNotaf()}");
      }
      else Console.WriteLine($"Reprovado!\nSua media final foi {materia.CalcMediaFinal()} com a nota da prova final sendo {materia.GetNotaf()}");
    }
    
    
  }
}
class Disciplina{
  private string nome;
  private int nota1, nota2, nota3, nota4, notaf;
  
  public int CalcMediaParcial(){
    return (nota1*2+nota2*2+nota3*3+nota4*3)/10;
  }
  public int CalcMediaFinal(){
    return (CalcMediaParcial()+notaf)/2;
  }
  
  public bool Aprov(){
    if (CalcMediaParcial() >= 60) return true;
    else return false;
  }
  public bool AprovF(){
    if (CalcMediaFinal() >= 60) return true;
    else return false;
  }
  

  public void SetNome(string nom){
    bool s_ou_n = true;
    foreach (char c in nom){
      switch(c){
        case '1':
        case '2':
        case '3':
        case '4':
        case '5':
        case '6':
        case '7':
        case '8':
        case '9':
        case '+':
        case '/':
        case ')':
        case '(':
        case '-':
        case '!':
        case '#':
        case '@':
        case '$':
        case '{':
        case '}':
        case '?':
        case '|':
        case '%':
        case '&':
        case '*': s_ou_n = false; break;
      }
      if (s_ou_n == false) break;
    }
    if (s_ou_n == true) nome = nom;
      
  }
  public string GetNome(){
    return nome;
  }

  public void SetNota1(int n){
    if (n <= 100 && n >= 0) nota1 = n;
  }
  public int GetNota1(){
    return nota1;
  }
  
  public void SetNota2(int n){
    if (n <= 100 && n >= 0) nota2 = n;
  }
  public int GetNota2(){
    return nota2;
  }
  
  public void SetNota3(int n){
    if (n <= 100 && n >= 0) nota3 = n;
  }
  public int GetNota3(){
    return nota3;
  }
  
  public void SetNota4(int n){
    if (n <= 100 && n >= 0) nota4 = n;
  }
  public int GetNota4(){
    return nota4;
  }
  
  public void SetNotaf(int n){
    if (n <= 100 && n >= 0) notaf = n;
  }
  public int GetNotaf(){
    return notaf;
  }
  
}