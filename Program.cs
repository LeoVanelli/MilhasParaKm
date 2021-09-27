using System;

namespace MilhasParaKm
{
    class Program
    {
        static void Main(string[] args)
        {
            // Objetivo: Receba uma medida em milhas e exiba seu equivalente em quilômetros. A medida em km é 1,609 vezes a medida em milhas.

            Console.Write("Entre com a medida (em milhas): ");

            double medida = double.Parse(Console.ReadLine());

            Console.WriteLine($"Milhas: {medida}\nQuilômetros: {medida*1609}");
        }
    }
}
