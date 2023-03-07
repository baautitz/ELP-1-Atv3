using System;

namespace Q05_FahrenheitParaCelsius {
    internal class Program {
        public static void Main(string[] args) {
            Console.Write("Defina o valor de Fahrenheit: ");
            string fahrenheitInput = Console.ReadLine();

            if (!double.TryParse(fahrenheitInput, out double fahrenheit)) {
                Console.WriteLine("Valor de Fahrenheit precisa ser um número.");
                Console.ReadKey();
                return;
            }

            double celsius = 5 / 9.0 * (fahrenheit - 32);
            Console.WriteLine("\n" + new string('-', Console.WindowWidth));
            Console.WriteLine($"Novo valor convertido para Celsius: {celsius}");
            Console.WriteLine(new string('-', Console.WindowWidth));
        }
    }
}