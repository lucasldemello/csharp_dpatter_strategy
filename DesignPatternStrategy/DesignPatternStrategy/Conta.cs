using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternStrategy
{
    public class Conta
    {
        public double Saldo { get; private set; }
        public String Titular { get; private set; }
        public String Numero { get; private set; }
        public String Agencia { get; private set; }
        public void Deposita(double valor)
        {
            this.Saldo += valor;
        }

        public Conta(String titular, double saldo)
        {
            this.Titular = titular;
            this.Saldo = saldo;
        }
    }
}
