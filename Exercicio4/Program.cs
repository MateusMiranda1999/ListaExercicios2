using System;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe sua idade:");
            int idade = int.Parse(Console.ReadLine());

            if (idade <= 19)
            {
                Console.WriteLine("Jovem");

            }
            else if (idade >= 20 && idade <= 59)
            {
                Console.WriteLine("Adulto");

            }
            else if (idade >= 60)
            {
                Console.WriteLine("Idoso");
            }
        }
    }
}
