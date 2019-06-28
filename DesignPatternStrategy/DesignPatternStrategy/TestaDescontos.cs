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

            Orcamento orcamento = new Orcamento(7000.0);
            orcamento.AdicionaItem(new Item("XBOX", 4000.0));
            orcamento.AdicionaItem(new Item("ps4", 3000.0));

            double desconto = calculador.Calcula(orcamento);

            Console.WriteLine(desconto);
            Console.ReadKey();
        }
    }
}
