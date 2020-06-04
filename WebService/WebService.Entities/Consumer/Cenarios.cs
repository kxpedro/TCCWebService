using System;
using System.Collections.Generic;
using System.Text;

namespace WebService.Entities.Consumer
{
    public class Cenarios
    {
        public int CenarioID { get; set; }
        public string EnderecoOrigem { get; set; }
        public string EnderecoDestino { get; set; }
        /// <summary>
        /// distance, time, cost    
        /// </summary>
        public string PreferenciaUsuario { get; set; }
        /// <summary>
        /// mode 
        /// </summary>
        public string TipoTransporte { get; set; }
        /// <summary>
        /// departure_time
        /// </summary>
        public TimeSpan HorarioSaida { get; set; }
    }
}
