using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    //A classe Aeronave herda da classe Veiculo
    internal class Aeronave : Veiculo
    {
        //O atributo QtdeTurbinas é definido somente para os Veículos do tipo Aeronave
        private int qtdeTurbinas;

        public int QtdeTurbinas { get => qtdeTurbinas; set => qtdeTurbinas = value; }

        //O construtor executa o construtor da classe base (Veiculo)
        //Construtor padrão vazio
        public Aeronave() { }

        //Construtor com atribuição direta (sobrecarga), já construindo o Tipo (Veiculo) e a QtdeTurbinas (Aeronave) diretamente ao ser instanciado
        public Aeronave(string _tipo, int _qtdeTurbinas)
        {
            Tipo = _tipo;
            QtdeTurbinas = _qtdeTurbinas;
        }

        //Sobrescreve o método Mover() usando o modificador override, fornecendo sua própria definição de Mover
        public override void Mover()
        {
            Console.WriteLine("Aeronave decolando...");
        }

        //Sobrescreve o método Parar() usando o modificador override, fornecendo sua própria definição de Parar
        public override void Parar()
        {
            Console.WriteLine("Aeronave pousando...");
        }
    }
}
