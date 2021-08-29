using System;
using System.Globalization;
namespace exercicio_estrutura_sequencial_05 {
    class Program {
        static void Main(string[] args) {
            double tot;


            string[] v = Console.ReadLine().Split(' ');
            int qtpeca = int.Parse(v[0]);
            double vlpaga = double.Parse(v[1]);

            String[] ve = Console.ReadLine().Split(' ');
            int qtpeca2 = int.Parse(ve[0]);
            double vlpaga2 = double.Parse(ve[1]);

            tot = vlpaga * qtpeca + vlpaga2 * qtpeca2;
            Console.WriteLine(tot);
        }
    }
}
