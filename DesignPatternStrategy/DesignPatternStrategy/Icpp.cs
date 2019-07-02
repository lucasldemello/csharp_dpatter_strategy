using System;
using System.Collections.Generic;
using System.Text;
using DesignPatternStrategy.Template;

namespace DesignPatternStrategy
{
    class Icpp : TemplateDeImpostoCondicional
    {
        override public bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor > 500;
        }

        override public double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.07;
        }

        override public double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.05;
        }
    }
}
