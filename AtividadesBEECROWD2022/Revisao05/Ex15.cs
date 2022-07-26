using System;
class Programa{
  
  public static void Main(string[] args){
    Console.WriteLine("Digite o numero do mês e do ano, respectivamente, separados por espaço: ");
    string[] m_a = Console.ReadLine().Split();
    int m = int.Parse(m_a[0]);
    int a = int.Parse(m_a[1]);
    Console.WriteLine(UltimoDia(m, a));
    
  }
  public static string UltimoDia(int mes, int ano){
    string a = ano.ToString();
    string m = mes.ToString();
    string d = "";
    string da = "365";
    if ((ano%100 != 0 && ano%400!=0 && ano%4==0) && mes == 2){
      d = "29";
      da = "366";
    }
    else{
      switch(mes){
        case 1: d = "31";break;
        case 2: d = "28";break;
        case 3: d = "30";break;
        case 4: d = "31";break;
        case 5: d = "31";break;
        case 6: d = "30";break;
        case 7: d = "31";break;
        case 8: d = "31";break;
        case 9: d = "30";break;
        case 10: d = "31";break;
        case 11: d = "30";break;
        case 12: d = "31";break;
        default: break;
      }
    }
    if (m.Length == 1) m = "0"+m;
    return "O utimo dia, no formato dd/mm/aaaa, é: "+d+"/"+m+"/"+a+"\nO ultimo dia do ano é: "+da;
  }
  
}
