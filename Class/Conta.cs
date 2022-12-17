using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace encontro_remoto_2.Class
{
    public abstract class  Conta
    {
        public long numeroConta {get; set;}
        public DateTime dataAbertura {get; set;}
        public DateTime? dataEncerramento {get; set;}
        public int situacao {get; set;}
        public int senha {get; set;}
        public int saldo {get; set;}

        public abstract bool validarSenha(int senha);
        public abstract double sacarValor(double valor, double saldo);
        public abstract double depositarValor(double valor, double saldo);
        public abstract double pagarImposto(double valor, double saldo);
    }
}