﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebService.Models
{
    public class Enderecos
    {
        [Key]
        public int EnderecosID { get; set; }        
        public string Rua { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string CEP { get; set; }

        public virtual Motorista Motorista { get; set; }
        public virtual Estacionamento Estacionamento { get; set; }
    }
}
