using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebService.Entities
{
    public class MotoristaPreferencias
    {
        [Key]
        public int MotoristaID { get; set; }
        public string ArrivalTime { get; set; }
        public TimeSpan DepartureTime { get; set; }
        

        public virtual Motorista Motorista { get; set; }
    }
}
