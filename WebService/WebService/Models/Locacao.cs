using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebService.Models
{
    public class Locacao
    {
        [Key]
        public int LocacaoID { get; set; }
        public DateTime Data { get; set; }
                        
        public virtual Estacionamento Estacionamento { get; set; }
        public virtual Motorista Motorista { get; set; }

    }
}
