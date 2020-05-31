using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebService.Entities
{
    public class EstacionamentoFluxo
    {
        [Key]
        public int EstacionamentoFluxoID { get; set; }
        public virtual Estacionamento Estacionamento { get; set; }
    }
}
