using System;

namespace Q01_Quadrado {
    public class Program {
        public static void Main(string[] args) {
            Console.Write("Defina um valor para lado: ");
            string ladoInput = Console.ReadLine();

            if (!int.TryParse(ladoInput, out int lado) || lado <= 0) {
                Console.Write("Valor de lado precisa ser um número inteiro e maior ou igual a zero.");
                Console.ReadKey();
                return;
            }
            
            int area = lado * lado;
            int perimetro = lado * 4;
            
            Console.WriteLine("\n" + new string('-', Console.WindowWidth));
            Console.WriteLine($"Valor de área calculada: {area}.");
            Console.WriteLine($"Valor de perímetro calculo: {perimetro}.");
            Console.WriteLine(new string('-', Console.WindowWidth));
            
            Console.ReadKey();
        }
    }
}