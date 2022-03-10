using System;
using System.Linq;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine($"Digite a quantida de vogais desejado");
            string descricao = Console.ReadLine();

            const string vogais = "aeiou";
            const string consoante = "bcdfgjklmnpqrstvxwyz";

            Console.WriteLine($"Numero de vogais:" + descricao.Count(y => vogais.Contains(y)) + 
                " Numero de consoante:" + descricao.Count(y => consoante.Contains(y)));
          
        }
    }
}
