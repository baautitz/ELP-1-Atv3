using System;

namespace Q10_SalarioLiquido {
    internal class Program {
        public static void Main(string[] args) {
            Console.Write("Defina o valor do salário bruto: ");
            string salBrutoInput = Console.ReadLine();

            if (!double.TryParse(salBrutoInput, out double salBruto) || salBruto < 0) {
                Console.WriteLine("Salário bruto precisa ser um número e maior que zero.");
                Console.ReadKey();
                return;
            }

            double inss = salBruto * 0.08;
            double ir = salBruto * 0.1;
            double filiacaoSindical = (salBruto - inss - ir) * 0.005;

            double totalDescontos = inss + ir + filiacaoSindical;
            double salLiquido = salBruto - totalDescontos;

            Console.WriteLine("\n" + new string('-', Console.WindowWidth));
            Console.WriteLine($"Desconto INSS: {inss}");
            Console.WriteLine($"Desconto IR: {ir}");
            Console.WriteLine($"Desconto Filiação Sidical: {filiacaoSindical}");
            Console.WriteLine(new string('-', Console.WindowWidth));
            Console.WriteLine($"Total de descontos: {totalDescontos}");
            Console.WriteLine(new string('-', Console.WindowWidth));
            Console.WriteLine($"Salário Líquido: {salLiquido}");
            Console.WriteLine(new string('-', Console.WindowWidth));
            Console.WriteLine("Bautitz é lindo!");
            Console.ReadKey();
        }
    }
}