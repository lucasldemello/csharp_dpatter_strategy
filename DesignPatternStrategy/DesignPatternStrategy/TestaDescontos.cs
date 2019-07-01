using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternStrategy
{
    public class TestaDescontos
    {
        static void Main(String[] args)
        {
            CalculadorDeDescontos calculador = new CalculadorDeDescontos();

            Orcamento orcamento = new Orcamento(1000.0);
            orcamento.AdicionaItem(new Item("CANETA", 400.0));
            orcamento.AdicionaItem(new Item("LAPIS", 600.0));

            double desconto = calculador.Calcula(orcamento);

            Console.WriteLine(desconto);
            Console.ReadKey();
        }
    }
}
