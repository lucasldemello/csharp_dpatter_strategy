using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternStrategy
{
    public interface Investimento
    {
        double Calcula(Conta conta);
    }
}
