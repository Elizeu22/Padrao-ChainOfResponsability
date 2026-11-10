using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability
{
    public abstract class Aprovador
    {
        protected Aprovador? proximoAprovador;

        public void DefinirProximo(Aprovador aprovador) 
        {
            proximoAprovador = aprovador;
        }

        public abstract void proximoFunc(int valor);
 
    }
}
