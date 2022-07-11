// using System;
// class Program {
//   public static void Main(string[] args) {  
    
//     //string a = Console.ReadLine();
//     //int b = int.Parse(Console.ReadLine());
//     //switch (a) {
//       //case "a":Console.WriteLine("Certo"); break;
//       //case "b":Console.WriteLine("Certo"); break;
//       //case "c":Console.WriteLine("Certo"); break;
//       //default:Console.WriteLine("Nãolistado"); break;
//     //}

//     int x = 4;
//     x = x << 1; // empura um bit para esquerda, ou seja, multiplica por 2
//     Console.WriteLine(x);
      
//   } 
// }


// using System;
// class Program{
//   public static void Main(string[] args){

//     string s = Console.ReadLine();
//     while(string.IsNullOrEmpty(s) != true){
//       int sn = int.Parse(s);
//       string[] abc = Console.ReadLine().Split();  
//       int a = int.Parse(abc[0]);
//       int b = int.Parse(abc[1]);
//       int c = int.Parse(abc[2]);
//       Console.WriteLine(MMC(a, b, c) - sn);
//       s = Console.ReadLine();
//     }

    
//     // Console.WriteLine(MMC(1,2,3));
//     // Console.WriteLine(MMC(2,4,8));
//     //string.IsNullOrEmpty(variavel) #devolve valor boleano
//     // precisa calcular mmc(começa do maior e vai somando 1); 
    
//   }
//   public static int MMC(int a, int b, int c){
//     int maior = a;
//     if (b > maior) maior=b;
//     if (c > maior) maior=c;
//     while (!(maior % a == 0 && maior % b == 0 && maior % c == 0)) maior++;
//     return maior;
//   }
// }



// using System;
// class Program{
//   public static void Main(string[] args){
//     int N = int.Parse(Console.ReadLine());
//     for (int at = 1; at <= N; at++){
//       string[] ab = Console.ReadLine().Split();
//       Console.WriteLine(MDC( int.Parse(ab[0]), int.Parse(ab[1])));  
//     }  
//   }
//   // public static int MDC(int a, int b){
//   //   int d = a;
//   //   if (b<d) d = b;
//   //   while(!(a%d == 0 && b%d == 0)){
//   //     d -= 1;  
//   //   }
//   //   return d;
//   // }
//   // public static int MDC(int a, int b){
//   //   while (!(a%b == 0)){
//   //     int d = a%b;
//   //     a = b;
//   //     b = d;
//   //   }
//   //   return b;
//   // }
//   public static int MDC(int a, int b){
//     if (a % b == 0) return b;
//     return MDC(b, a%b);
  
//   }
  
// }