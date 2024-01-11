using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Modo 1 de instanciar objetos, atribuir e chamar:
            /*
            Aeronave aeronave = new Aeronave();
            Automovel automovel = new Automovel();
            aeronave.Tipo = "Avião";
            aeronave.QtdeTurbinas = 2;
            aeronave.Mover();
            aeronave.Parar();
            automovel.Tipo = "Carro";
            automovel.QtdeRodas = 4;
            automovel.Mover();
            automovel.Parar();
            */

            //Modo 2 de instanciar objetos, atribuir e chamar:
            /*
            Aeronave aeronave = new Aeronave("Avião", 2);
            Automovel automovel = new Automovel("Carro", 4);
            aeronave.Mover();
            aeronave.Parar();
            automovel.Mover();
            automovel.Parar();
            */

            //Modo 3 de instanciar objetos, atribuir e chamar:
            /*
            Veiculo[] veiculos = new Veiculo[2];
            veiculos[0] = new Aeronave("Avião", 2);
            veiculos[1] = new Automovel("Carro", 4);

            for (int i = 0; i < veiculos.Length; i++)
            {
                Console.WriteLine("Tipo do Veículo: " + veiculos[i].GetType().Name);
                veiculos[i].Mover();
                veiculos[i].Parar();
            }
            */

            //Modo 4 de instanciar objetos, atribuir e chamar:
            /*
            Veiculo[] veiculos = new Veiculo[] {
                new Aeronave { Tipo = "Avião", QtdeTurbinas = 2},
                new Automovel {Tipo = "Carro", QtdeRodas = 4}
            };

            Console.WriteLine("Ações dos Veículos:\n");
            foreach (var v in veiculos)
            {
                Console.WriteLine("Tipo do Veículo: " + v.Tipo);
                v.Mover();
                v.Parar();
            }
            */

            //Modo 5 de instanciar objetos, atribuir e chamar:
            Veiculo[] veiculos = new Veiculo[] {
                new Aeronave("Avião", 2),
                new Aeronave("Helicóptero", 0),
                new Automovel("Carro", 4),
                new Automovel("Moto", 2)
            };

            Console.WriteLine("Ações dos Veículos:");
            foreach (var veiculo in veiculos)
            {
                Console.WriteLine($"\nTipo do Veículo: {veiculo.Tipo}");

                if (veiculo.GetType() == typeof(Aeronave))
                {
                    var aeronave = (Aeronave)veiculo;
                    Console.WriteLine($"Essa aeronave possui {aeronave.QtdeTurbinas} turbinas.");
                }
                else
                {
                    var automovel = (Automovel)veiculo;
                    Console.WriteLine($"Esse automóvel possui {automovel.QtdeRodas} rodas.");
                }

                veiculo.Mover();
                veiculo.Parar();
            }
        }
    }
}
