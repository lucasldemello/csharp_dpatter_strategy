using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternStrategy
{
    // Crie o imposto que se chama ICCC, 
    // que retorna 5% do valor total caso o orçamento seja menor do que R$ 1000,00 reais, 
    // 7% caso o valor esteja entre R$ 1000 e R$ 3000,00 com os limites inclusos, ou 8% mais 30 reais, caso o valor esteja acima de R$ 3000,00.
    public class Iccc : Imposto
    {
        public double Calcula(Orcamento orcamento)
        {
            if (orcamento.Valor <= 1000.0)
            {
                return orcamento.Valor * 0.05;
            }
            else if (1000.0 < orcamento.Valor && orcamento.Valor >= 3000.0)
            {
                return orcamento.Valor * 0.07;
            }
            else
            {
                return (orcamento.Valor * 0.08) + 30.0;
            }

            return orcamento.Valor * 0.06;
        }
    }
}
