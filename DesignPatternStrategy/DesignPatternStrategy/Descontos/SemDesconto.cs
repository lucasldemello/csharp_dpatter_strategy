using DesignPatternStrategy.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternStrategy.Descontos
{
    class SemDesconto : IDesconto
    {
        public IDesconto Proximo { get; set; }

        public Double Desconta(Orcamento orcamento)
        {
            return 0;
        }
    }
}
