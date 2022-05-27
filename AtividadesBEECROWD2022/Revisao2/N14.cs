using System;
class Program {
  public static void Main(string[] args) {  

    Console.WriteLine("Digite 3 valores:");
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());
    int c = int.Parse(Console.ReadLine());

    if((Math.Abs((b - c)) < a && a < b + c) ||  (Math.Abs((a - c))< b && b < a + c) || (Math.Abs((b-a))< c && c < b + a)){
      if (a == b && b == c){
        Console.WriteLine("Equilatero");
      } 
      else if (((a==b && a != c)) || ((c==b && c != a)) || ((a==c && a != b))) {
        Console.WriteLine("Isoceles");
      }
      else if (a != b && b != c && a != c) {
        Console.WriteLine("Escaleno");
      }
    }
    else {
      Console.WriteLine("Esses valores não formam um triângulo");
    }

  } 
}