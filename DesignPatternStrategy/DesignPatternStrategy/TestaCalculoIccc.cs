using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternStrategy
{
    class TestaCalculoIccc
    {
        static void Main(String[] args)
        {
            Imposto iccc = new Iccc();
            Orcamento orcamento1 = new Orcamento(3000.1);

            CalculadorDeImposto calculador = new CalculadorDeImposto();

            // Calculando o ISS
            calculador.RealizaCalculo(orcamento1, iccc);

            Console.ReadKey();
        }
    }
}
