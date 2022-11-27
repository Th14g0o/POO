using System;
class BeeCrowd{
  public static void Main(string[] args){

    
    string input = Console.ReadLine();
    int contador = 1;
    
    while (String.IsNullOrEmpty(input) != true){
      
      int digitos = int.Parse(input);
      string[] oleosidades = Console.ReadLine().Split(' ');
      double[] valores = new double[10];
      string senha = "";
      
      for (int indice = 0; indice < 10; indice++){
        valores[indice] = double.Parse(oleosidades[indice]);
      }
      
      double[] copia = new double[10];
      
      Array.Copy(valores, copia, 10);
      Array.Sort(copia);
      Array.Reverse(copia);

      string[] senha_v = new string[digitos];
      int posi = 0;
      int teste = 0;
      
      for (int indice = 0; indice<digitos; indice++){
        
        string posicao = Array.IndexOf(valores, copia[indice]).ToString();
        
        if(Array.IndexOf(senha_v,  posicao) == -1){
          senha_v[indice] = posicao;
        }
        
        else{

          teste = Array.IndexOf(valores, copia[indice]);
          while (teste != -1){
            posi = teste;
            valores[posi] = 2;
            
            teste = Array.IndexOf(valores, copia[indice]);
            if (posi != int.Parse(posicao)) break;
          }
          
          senha_v[indice-1] = Math.Min(int.Parse(senha_v[indice-1]), posi).ToString();
          senha_v[indice] = Math.Max(int.Parse(senha_v[indice-1]), posi).ToString() ;
          
        }
          
      }      
      
      foreach (string c in senha_v){
        senha += c;
      }   
      
      Console.WriteLine($"Caso {contador}: {senha}");
      contador++;
      input = Console.ReadLine();
      
    }
  }
}
//1 1 1 0 9 9 7 8 5 6
//1 1 1 0 9 9 7 8 5 0