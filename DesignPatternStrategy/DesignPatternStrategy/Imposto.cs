using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternStrategy
{
    public interface Imposto
    {
        double Calcula(Orcamento orcamento);
    }
}
