using System;
class BeeCrowd{
    public static void Main(string[] args){
       double[] A = new double[100];

        for (int i = 0; i < A.Length; i++){
            double n = double.Parse(Console.ReadLine());
            A[i] = n;
        }

        for (int i = 0; i < A.Length; i++){
            if (A[i] <= 10) Console.WriteLine($"A[{i}] = {A[i]:0.0}");
        }

    }
}