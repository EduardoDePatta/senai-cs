using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace encontro_remoto_2.Class
{
    public abstract class Movimentacao
    {
        private int tipoMovimentacao{get; set;}
        private DateTime dataMovimentacao{get; set;}
        private double valorMovimentacao{get; set;}
        public abstract string registroMovimentacao(double valorMovimentacao, DateTime dataMovimentacao);
        public abstract string conferirMovimentacao(DateTime dataMovimenatcao);
    }
}