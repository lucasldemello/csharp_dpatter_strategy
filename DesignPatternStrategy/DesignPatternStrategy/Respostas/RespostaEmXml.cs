using DesignPatternStrategy.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternStrategy.Respostas
{
    class RespostaEmXml : IResposta
    {
        public IResposta OutraResposta { get; private set; }

        public RespostaEmXml(IResposta outraResposta)
        {
            this.OutraResposta = outraResposta;
        }

        public void Responde(Requisicao req, Conta conta)
        {
            if (req.Formato == Formato.XML)
            {
                Console.WriteLine("<conta><titular>" + conta.Titular + "</titular><saldo>" + conta.Saldo + "</saldo></conta>");
            }
            else
            {
                OutraResposta.Responde(req, conta);
            }
        }
    }

}
