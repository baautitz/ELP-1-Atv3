using System;

namespace Q03_Circulo {
    internal class Program {
        public static void Main(string[] args) {
            Console.Write("Defina o valor do raio: ");
            string raioInput = Console.ReadLine();

            if (!double.TryParse(raioInput, out double raio) || raio < 0) {
                Console.WriteLine("Valor de raio precisa ser um número e maior que zero.");
                Console.ReadKey();
                return;
            }

            double circunf = 2 * Math.PI * raio;
            double area = Math.PI * (Math.Pow(raio, 2));
            double diam = 2 * raio;

            Console.WriteLine("\n" + new string('-', Console.WindowWidth));
            Console.WriteLine($"Valor de area calculado: {area:F2}");
            Console.WriteLine($"Valor de circunferência calculado: {circunf:F2}");
            Console.WriteLine($"Valor de diâmetro calculado: {diam}");
            Console.WriteLine(new string('-', Console.WindowWidth));
            Console.ReadKey();
        }
    }
}