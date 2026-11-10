using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability
{
    internal class Presidente:Aprovador
    {
        public override void proximoFunc(int valor)
        {
            if (valor >5000)
            {
                Console.WriteLine("Resolução feita pelo diretor");
            }
            else
            {
                Console.WriteLine("Problema sem resolução");

            }

        }
    }
}
