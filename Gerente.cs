using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability
{
    public class Gerente:Aprovador
    {
        public override void proximoFunc(int valor)
        {
            if(valor >0 && valor <= 500) 
            {
                Console.WriteLine("Resolução feita pelo gerente");
            }
            else if (proximoAprovador!=null)
            {
                proximoAprovador.proximoFunc(valor);

            }

        }
    }
}
