using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternStrategy.Interface
{
    interface IResposta
    {
        void Responde(Requisicao req, Conta conta);

    }
}
