using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace encontro_remoto_2.Class
{
    public abstract class Pessoa
    {
        public string? nome {get; set;}
        public float rendimento {get; set;}
        public Endereco? endereco {get; set;}
        public Conta? conta {get; set;}
        public abstract float CalcularImposto(float rendimento);
    }
}