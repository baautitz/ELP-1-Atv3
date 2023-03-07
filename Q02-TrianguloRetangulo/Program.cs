
using System;

namespace Q02_TrianguloRetangulo {
    internal class Program {
        public static void Main(string[] args) {
            Console.Write("Defina um valor para base: ");
            string tBaseInput = Console.ReadLine();

            if (!double.TryParse(tBaseInput, out double tBase) || tBase < 0) {
                Console.Write("Valor de base precisa ser um número e maior  a zero.");
                Console.ReadKey();
                return;
            }
            
            Console.Write("Defina um valor para altura: ");
            string tAlturaInput = Console.ReadLine();

            if (!double.TryParse(tAlturaInput, out double tAltura) || tAltura < 0) {
                Console.Write("Valor de altura precisa ser um número e maior a zero.");
                Console.ReadKey();
                return;
            }

            double area = (tBase * tAltura) / 2;
            double hipotenusa = Math.Sqrt(Math.Pow(tBase, 2) + Math.Pow(tAltura, 2));
            double perimetro = tBase + tAltura + hipotenusa;
            
            Console.WriteLine("\n" + new string('-', Console.WindowWidth));
            Console.WriteLine($"Valor da hipotenusa calculada: {hipotenusa:F2}");
            Console.WriteLine(new string('-', Console.WindowWidth));
            Console.WriteLine($"Valor de área calculada: {area:F2}");
            Console.WriteLine($"Valor de perímetro calculo: {perimetro:F2}");
            Console.WriteLine(new string('-', Console.WindowWidth));
            
            Console.ReadKey();
        }
    }
}