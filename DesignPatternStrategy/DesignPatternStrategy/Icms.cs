using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternStrategy
{
    class Icms : Imposto
    {
        public double Calcula(Orcamento orcamento)
        {
            return (orcamento.Valor * 0.1) + 50.0;
        }
    }
}
