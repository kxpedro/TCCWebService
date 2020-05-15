using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebService.Entities
{
    public class MotoristaVeiculos
    {
        [Key]
        public int MotoristaVeiculosID { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Placa { get; set; }
        public string Cor { get; set; }
        public string Portas { get; set; }

        public virtual Motorista Motorista { get; set; }
    }
}
