using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Polimorfismo
{
    internal class Veiculo
    {
        //O atributo Tipo define o tipo do veículo
        private string tipo;

        public string Tipo { get => tipo; set => tipo = value; }

        //Construtor padrão vazio
        public Veiculo() { }

        //Construtor com atribuição direta (sobrecarga), já construindo o Tipo diretamente ao ser instanciado
        public Veiculo(string _tipo)
        {
            Tipo = _tipo;
        }

        //O modificador de acesso virtual indica que o método pode ser sobrescrito na classe derivada
        //O método virtual Mover() define o comportamento Mover padrão a todo tipo de veículo
        public virtual void Mover()
        {
            Console.WriteLine("Veículo em movimento!");
        }

        //O método virtual Parar() define o comportamento Parar padrão a todo tipo de veículo
        public virtual void Parar()
        {
            Console.WriteLine("Veículo parou");
        }
    }
}
