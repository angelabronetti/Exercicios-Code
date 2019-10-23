using System;

namespace Cálculo_de_Média {
    class Program {
        static void Main (string[] args) {

            int n1, n2;

            Console.WriteLine ("Informe um número");
            n1 = int.Parse (Console.ReadLine ());

            Console.WriteLine ("Informe outro número");
            n2 = int.Parse (Console.ReadLine ());

            if (n1 % 2 == 0) {
                Console.WriteLine ("O número é par");
            } else {
                Console.WriteLine ("O número é ímpar");
            }
        }
    }
}