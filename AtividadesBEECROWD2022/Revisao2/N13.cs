using System;
class Program {
  public static void Main(string[] args) {  

    Console.WriteLine("Digite dez valores inteiros");
    string[] ns = Console.ReadLine().Split();
    int n1 = int.Parse(ns[0]);
    int n2 = int.Parse(ns[1]);
    int n3 = int.Parse(ns[2]);
    int n4 = int.Parse(ns[3]);
    int n5 = int.Parse(ns[4]);
    int n6 = int.Parse(ns[5]);
    int n7 = int.Parse(ns[6]);
    int n8 = int.Parse(ns[7]);
    int n9 = int.Parse(ns[8]);
    int n10 = int.Parse(ns[9]);

    int maior = n1;
    int menor = n1;

    if(maior < n2) maior = n2;
    if(maior < n3) maior = n3;
    if(maior < n4) maior = n4;
    if(maior < n5) maior = n5;
    if(maior < n6) maior = n6;
    if(maior < n7) maior = n7;
    if(maior < n8) maior = n8;
    if(maior < n9) maior = n9;
    if(maior < n10) maior = n10;

    if(menor > n2) menor = n2;
    if(menor > n3) menor = n3;
    if(menor > n4) menor = n4;
    if(menor > n5) menor = n5;
    if(menor > n6) menor = n6;
    if(menor > n7) menor = n7;
    if(menor > n8) menor = n8;
    if(menor > n9) menor = n9;
    if(menor > n10) menor = n10;

    Console.WriteLine($"O maior valor é {maior} e o menor é {menor}");

  } 
}