using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobrecarga
{
    internal class Calcular
    {
        //Método Somar com assinatura (parâmetros) 'a' e 'b', retornando a soma entre eles
        public int Somar(int a, int b)
        {
            return a + b;
        }

        //Método Somar com assinatura (parâmetros) 'a', 'b' e 'c', retornando a soma entre eles
        public int Somar(int a, int b, int c)
        {
            return a + b + c;
        }

        //Método Somar com assinatura (parâmetros) 'a' e 'b', porém agora aceitando float
        public float Somar(float a, float b)
        {
            return a + b;
        }
    }
}
