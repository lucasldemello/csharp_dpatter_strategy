using DesignPatternStrategy.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternStrategy.Respostas
{
    class RespostaEmCsv : IResposta
    {
        public IResposta OutraReposta { get; private set; }

        public RespostaEmCsv(IResposta outraResposta)
        {
            this.OutraReposta = outraResposta;
        }

        public void Responde(Requisicao req, Conta conta)
        {
            if (req.Formato == Formato.CSV)
            {
                Console.WriteLine(conta.Titular + ";" + conta.Saldo);
            }
            else
            {
                this.OutraReposta.Responde(req, conta);
            }
        }
    }
    }
}
