﻿using System;
using System.Collections.Generic;
using System.Text;
using DesignPatternStrategy.Template;

namespace DesignPatternStrategy
{
    public class Ikcv : TemplateDeImpostoCondicional
    {
        override public bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor > 500 && temItemMaiorQue100ReaisNo(orcamento);
        }

        override public double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.10;
        }

        override public double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06;
        }
        
        private bool temItemMaiorQue100ReaisNo(Orcamento orcamento)
        {
            foreach (Item item in orcamento.Itens)
            {
                if (item.Valor > 100) return true;
            }

            return false;
        }
    }
}
