using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio01
{
    class PesquisaFim : Pesquisa
    {
        public override sealed bool BuscarString(string CadeiaCaracteres)
        {
            if (Text is null)
                return false;

            return Text.EndsWith(CadeiaCaracteres);
        }
    }
}
