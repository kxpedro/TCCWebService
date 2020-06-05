using System;
using System.Collections.Generic;
using System.Text;

namespace WebService.Business.Consumer
{
    public class CabBusiness
    {
        public double GetCosts(int tempoViagemEmSegundos, int distanciaViagemEmMetros, TimeSpan horaDeSaida)
        {
            TimeSpan bandeira1Inicio = new TimeSpan(6, 0, 0);
            TimeSpan bandeira1Fim = new TimeSpan(20, 0, 0);
            bool isBandeira1 = false;

            TimeSpan bandeira2Inicio = new TimeSpan(20, 0, 0);
            TimeSpan bandeira2Fim = new TimeSpan(6, 0, 0);
            bool isBandeira2 = false;

            return 0;
        }
    }
}
