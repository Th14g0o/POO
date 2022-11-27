using System;
class ListaPoo04{
  public static void Main(string[] args){
    // Musica m1 = new Musica("Easy", "BArreto", "Albos");
    // Musica m2 = m1; //apenas mais uma referencia para o mesmo objeto
    // //Console.WriteLine(m1);
    // //Console.WriteLine(m1.ToString());//mesma coisa que o da linha 6
    // Musica[] musicas = new Musica[10];
    // Musica m3 = new Musica("Musica2", "Pessoa2", "Album2");
    // musicas[0] = m1;
    // musicas[1] = m3;
    // foreach(Musica m in musicas){
    //   Console.WriteLine(m);
    // }
    Musica m1 = new Musica("Easy", "BArreto", "Albos");
    Musica m2 = new Musica("Musica2", "Pessoa2", "Album2");
    Playlist lista1 = new Playlist("POO");
    lista1.Inserir(m1);
    lista1.Inserir(m2);

    Console.WriteLine("Digite as infos:");
    string t = Console.ReadLine();
    string a = Console.ReadLine();
    string al = Console.ReadLine();

    while((string.IsNullOrEmpty(t) != true) || (string.IsNullOrEmpty(a) != true) || (string.IsNullOrEmpty(al) != true)){
      Musica m = new Musica(t, a, al);
      t = Console.ReadLine();
      a = Console.ReadLine();
      al = Console.ReadLine();
      lista1.Inserir(m);
    }
    
    Console.WriteLine(lista1);
    foreach (Musica m in lista1.Listar()){
      Console.WriteLine(m);
    }
  }
}

class Playlist{
  private string nome;
  private Musica[] musicas = new Musica[10];
  private int contador;
  public Playlist(string n){
    nome = n;
  }
  
  public void SetNome(string n){
    nome = n;
  }

  public void Inserir(Musica m){
    if (contador == musicas.Length)
      Array.Resize(ref musicas, musicas.Length * 2); //pressisa usar o ref 
    musicas[contador] = m;
    contador++;
  }
  
  public override string ToString(){
    return $"Playlist({nome})";
  }
  public Musica[] Listar(){
    Musica[] vetor = new Musica[contador];
    Array.Copy(musicas, vetor, contador);
    return vetor;
  }

  
}

class Musica{
  private string titulo, artista, album ;

  public Musica(string t, string a, string al){
    titulo = t;
    artista = a;
    album = al;
  }
  
  public void SetTit(string t){
    titulo = t;
  }
  public void SetArt(string t){
    artista = t;
  }
  public void SetAlb(string t){
    album = t;
  }

  public override string ToString(){
    return $"{titulo} - {artista} - {album}";
  }

  
}