using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio04
{
    enum Options : uint
    {
        INVALIDO = 0,
        CADASTRAR = 1,
        REMOVER = 2,
        LISTAR = 3
    }

    enum TipoCliente : uint
    {
        PESSOA_FISICA = 1,
        PESSOA_JURIDICA = 2,
    }
}
