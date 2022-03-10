using System;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a sua data de aniversário: ");
            string dataAniversario = Console.ReadLine();

            DateTime.TryParse(dataAniversario,
              out DateTime dataAniversarioFormatada);

            Console.WriteLine("Sua idade é de " +
               $"{DateTime.Today.Year - dataAniversarioFormatada.Year} anos!");

            Console.ReadLine();
        }
    }
}
