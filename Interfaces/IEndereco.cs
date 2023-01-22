using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace encontro_remoto_2.Interfaces
{
    public interface IEndereco
    {
        public int numero{get; set;}
        public string logradouro{get; set;}
        public string bairro{get; set;}
        public string complemento{get; set;}
        public bool endComercial{get; set;}

    }
}