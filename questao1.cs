using System;

 class Program
 {
     static void Main()
     {
         int Indice = 13, Soma = 0, K = 0;

         while (K < Indice)
         {
             K = K + 1;
             Soma = Soma + K;
         }

         Console.WriteLine(Soma);
     }
}
