using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebService.Models
{
    public class Motorista
    {
        public string NomeCompleto { get; set; }
        public string CPF { get; set; }
        public DateTime Nascimento { get; set; }       

        public virtual IEnumerable<Endereco> Endereco { get; set; }
        public virtual IEnumerable<Contatos> Contatos { get; set; }
    }
}
