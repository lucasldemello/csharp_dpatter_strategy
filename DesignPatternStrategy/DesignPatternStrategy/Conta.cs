﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternStrategy
{
    public class Conta
    {
        public double Saldo { get; private set; }
        public void Deposita(double valor)
        {
            this.Saldo += valor;
        }
    }
}
