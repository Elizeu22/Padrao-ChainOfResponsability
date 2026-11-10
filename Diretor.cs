using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability
{
    public class Diretor:Aprovador
    {
        public override void proximoFunc(int valor)
        {
            if (valor > 500 && valor <= 5000)
            {
                Console.WriteLine("Resolução feita pelo diretor");
            }
            else if (proximoAprovador != null)
            {
                proximoAprovador.proximoFunc(valor);

            }

        }
    }
}
