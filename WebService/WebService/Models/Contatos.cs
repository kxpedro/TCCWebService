using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebService.Models
{
    public class Contatos
    {
        [Key]
        public int ContatosID { get; set; }
        public string Titulo { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        
        public virtual Motorista Motorista { get; set; }
        public virtual Estacionamento Estacionamento { get; set; }
    }
}
