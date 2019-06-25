using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternStrategy
{
    public class CalculadorDeImposto
    {
        public void RealizaCalculo(Orcamento orcamento, Imposto imposto)
        {
            double valor = imposto.Calcula(orcamento);
            Console.WriteLine(valor);
        }
    }
}
