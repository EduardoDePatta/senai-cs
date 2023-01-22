using System.Text.RegularExpressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using encontro_remoto_2.Interfaces;

namespace encontro_remoto_2.Class
{
    public class PessoaJuridica: Pessoa, IPessoaJuridica 
    {
        public string? cnpj{get; set;}
        private float valorImposto;

        public override float CalcularImposto(float rendimento)
        {
            switch (rendimento)
            {
                case (<= 3000):
                    return valorImposto = (rendimento / 100) * 3;
                case (<= 6000):
                    return valorImposto = (rendimento / 100) * 5;
                case (<= 10000):
                    return valorImposto = (rendimento / 100) * 7;
                default:
                    return valorImposto = (rendimento / 100) * 9;
            }  
        }

        bool IPessoaJuridica.CalcularImposto(float rendimento)
        {
            throw new NotImplementedException();
        }
    }
}