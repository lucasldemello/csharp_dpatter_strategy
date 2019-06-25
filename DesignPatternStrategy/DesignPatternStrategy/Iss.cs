using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternStrategy
{
    class Iss : Imposto
    {
        public double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06;
        }
    }
}
