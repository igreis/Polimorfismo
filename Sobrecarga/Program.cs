using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobrecarga
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calcular calcular = new Calcular();
            Console.WriteLine("\nPolimorfismo com sobrecarga:\n");
            Console.WriteLine("Somando 2 números inteiros...");
            Console.WriteLine(calcular.Somar(10, 20));
            Console.WriteLine("Somando 3 números inteiros...");
            Console.WriteLine(calcular.Somar(13, 28, 53));
            Console.WriteLine("Somando 2 números decimais...");
            Console.WriteLine(calcular.Somar(2.5f, 7.9f));
        }
    }
}
