using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using encontro_remoto_2.Interfaces;

namespace encontro_remoto_2.Class
{
    public class PessoaFisica: Pessoa, IPessoaFisica
    {
        public string? cpf {get; set;}
        public DateTime dataNasc {get; set;}
        private float valorImposto;

        public override float CalcularImposto(float rendimento)
        {           
            switch (rendimento)
            {
                case (<= 1500):
                    return valorImposto = 0;
                case (<= 3500):
                    return valorImposto = (rendimento / 100) * 2;
                case (<= 6000):
                    return valorImposto = (rendimento / 100) * 3.5f;
                default:
                    return valorImposto = (rendimento / 100) * 5;
            }          
        }

        public bool ValidarDataNascimento(DateTime dataNasc)
        {
            DateTime dataAtual = DateTime.Today;
            double idadePessoaFisica = Math.Floor(((dataAtual - dataNasc).TotalDays)/365);
            switch (idadePessoaFisica)
            {
                case ( <= 18 ):
                    return false;
                default:
                    return true;
            }
        }
        public bool ValidarDataNascimento(string dataNasc)
        {
            if (DateTime.TryParse(dataNasc, out DateTime dataConvertida)) {
                DateTime dataAtual = DateTime.Today;
                double idadePessoaFisica = Math.Floor(((dataAtual - dataConvertida).TotalDays)/365);

                if (idadePessoaFisica >= 18)
                {
                    return true;
                }
            }
            return false;
        }
    }
}