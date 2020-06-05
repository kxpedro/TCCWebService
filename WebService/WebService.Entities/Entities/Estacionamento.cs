using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebService.Entities
{
    public class Estacionamento
    {
        [Key]
        public int EstacionamentoID { get; set; }
        public string NomeFantasia { get; set; }
        public string RazaoSocial { get; set; }
        public string CNPJ { get; set; }
        public int Vagas { get; set; }
        public virtual Enderecos Endereco { get; set; }
        public virtual IEnumerable<Contatos> Contatos { get; set; }
        public virtual IEnumerable<EstacionamentoFluxo> EstacionamentoFluxo { get; set; }
        public virtual IEnumerable<EstacionamentoValores> EstacionamentoValores { get; set; }
        public virtual IEnumerable<Locacao> Locacao { get; set; }
    }
}
