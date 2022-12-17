using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace encontro_remoto_2.Interfaces
{
    public interface IPessoaFisica
    {
        bool ValidarDataNascimento(DateTime dataNasc);
    }
}