using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternStrategy.Interface
{
    public interface IDesconto
    {
        Double Desconta(Orcamento orcamento);
        IDesconto Proximo { get; set; }
    }
}
