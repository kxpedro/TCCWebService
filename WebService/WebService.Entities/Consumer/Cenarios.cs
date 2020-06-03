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
        public string PreferenciaUsuario { get; set; }
        public string TipoTransporte { get; set; }
        public TimeSpan HorarioSaida { get; set; }
    }
}
