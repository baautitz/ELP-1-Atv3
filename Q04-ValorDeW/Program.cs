using System;

namespace Q04_ValorDeW {
    internal class Program {
        public static void Main(string[] args) {
            Console.Write("Defina o valor de T: ");
            string tInput = Console.ReadLine();

            if (!double.TryParse(tInput, out double t)) {
                Console.WriteLine("Valor de T precisa ser um número.");
                Console.ReadKey();
                return;
            }

            double x = 2 * t - 4;
            double y = t / 2 + 4;

            double w = 2 * t + 4 * y - 3 * x;

            Console.WriteLine("\n" + new string('-', Console.WindowWidth));
            Console.WriteLine($"Valor de W calculado: {w}");
            Console.WriteLine(new string('-', Console.WindowWidth));
        }
    }
}