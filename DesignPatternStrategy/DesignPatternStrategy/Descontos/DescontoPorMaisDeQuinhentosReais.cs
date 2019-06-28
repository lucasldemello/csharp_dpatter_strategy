﻿using System;
using System.Collections.Generic;
using System.Text;
using DesignPatternStrategy.Interface;

namespace DesignPatternStrategy.Descontos
{
    class DescontoPorMaisDeQuinhentosReais : IDesconto 
    {
        public IDesconto Proximo { get; set; }

        public double Desconta(Orcamento orcamento)
        {
            if (orcamento.Valor > 500)
            {
                return orcamento.Valor * 0.07;
            }
            else
            {
                return Proximo.Desconta(orcamento);
            }
        }
    }
}
