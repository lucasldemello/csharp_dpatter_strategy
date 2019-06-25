using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternStrategy
{
    class ContaBancaria
    {
        public double Saldo { get; private set }

        public ContaBancaria ( double saldo)
        {
            this.Saldo = saldo;
        }
    }
}
