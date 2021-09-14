using System;
using System.Collections.Generic;
using System.Linq;

namespace TechnicalChallengeFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            bool success;
            do
            {
                try
                {
                    Console.Write("Digite um número: ");
                    int number = int.Parse(Console.ReadLine());
                    var op = new TechnicalChallengeLibrary.Main();
                    var entity = op.DiscoverDividingAndPrimeNumbers(number);
                    if (entity.Success)
                    {
                        Console.Write("Números divisores: ");
                        entity.Entity.DividingNumbers.ForEach(x =>
                        {
                            Console.Write($" {x}");
                        });
                        Console.WriteLine();
                        Console.Write("Números primos: ");
                        entity.Entity.PrimeNumbers.ForEach(x =>
                        {
                            Console.Write($" {x}");
                        });
                        Console.WriteLine();
                    }
                    else
                        Console.WriteLine("Valor inválido! Digite um número inteiro positivo");

                    success = RepeatOperation();
                }
                catch (Exception)
                {
                    Console.WriteLine("Valor inválido! Digite um número inteiro positivo");
                    success = RepeatOperation();
                }

            } while (success);
        }
        private static bool RepeatOperation()
        {
            Console.WriteLine("Deseja refazer a operação ? (S/N)");
            var resp = Console.ReadLine().ToLower();
            return resp == "s" ? true : false;

        }

    }
}
