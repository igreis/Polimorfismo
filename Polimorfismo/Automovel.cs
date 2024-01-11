using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    //A classe Automovel herda da classe Veiculo
    internal class Automovel : Veiculo
    {
        //O atributo QtdeRodas é definido somente para os Veículos do tipo Automóvel
        private int qtdeRodas;

        public int QtdeRodas { get => qtdeRodas; set => qtdeRodas = value; }

        //O construtor executa o construtor da classe base (Veiculo)
        //Construtor padrão vazio
        public Automovel() { }

        //Construtor com atribuição direta (sobrecarga), já construindo o Tipo (Veiculo) e a QtdeTurbinas (Aeronave) diretamente ao ser instanciado
        public Automovel(string _tipo, int _qtdeRodas)
        {
            Tipo = _tipo;
            QtdeRodas = _qtdeRodas;
        }

        //Sobrescreve o método Mover() usando o modificador override, fornecendo sua própria definição de Mover
        public override void Mover()
        {
            Console.WriteLine("Automóvel se movendo na rua...");
        }

        //Sobrescreve o método Parar() usando o modificador override, fornecendo sua própria definição de Parar
        public override void Parar()
        {
            Console.WriteLine("Automóvel parou na garagem.");
        }
    }
}
