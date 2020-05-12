using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebService.Models
{
    public class Motorista
    {
        [Key]
        public int MotoristaID { get; set; }
        public string NomeCompleto { get; set; }
        public string CPF { get; set; }
        public DateTime Nascimento { get; set; }       

        public virtual IEnumerable<Enderecos> Endereco { get; set; }
        public virtual IEnumerable<Contatos> Contatos { get; set; }
        public virtual IEnumerable<Locacao> Locacao { get; set; }
    }
}
