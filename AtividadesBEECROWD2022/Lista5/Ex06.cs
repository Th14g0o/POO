using System;
class Program {
  public static void Main(string[] args) {
    
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());
    int c = int.Parse(Console.ReadLine());

    int A1 = (b*2) + (c*4);
    int A2 = (a*2) + (c*2);
    int A3 = (a*4) + (b*2);

    int menor = A1;

    if (A2 < menor) {
      menor = A2;
    }
    
    if (A3 < menor) {
      menor = A3;
    }
    Console.WriteLine(menor);
    
    /*if (A1 <= A2 && A1 <= A3) {
      Console.WriteLine(A1);
    }
    else if (A2 <= A1 && A2 <= A3) {
      Console.WriteLine(A2);
    }
    else if (A3 <= A2 && A3 <= A1){
      Console.WriteLine(A3);
    }*/
    
  }
}