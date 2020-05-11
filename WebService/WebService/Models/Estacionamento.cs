using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebService.Models
{
    public class Estacionamento
    {
        public string NomeFantasia { get; set; }
        public string RazaoSocial { get; set; }
        public string CNPJ { get; set; }

        public virtual IEnumerable<Endereco> Endereco { get; set; }
        public virtual IEnumerable<Contatos> Contatos { get; set; }
    }
}
