using System;
using System.Collections.Generic;
using System.Text;
using WebService.Consuming;

namespace WebService.Business.Consumer
{
    public class CabBusiness
    {
        public double GetCosts(int tempoViagemEmSegundos, int distanciaViagemEmMetros, TimeSpan horaDeSaida)
        {
            CabConsumer cabConsumer = new CabConsumer();

            double bandeira1Valor = 2.50;            

            return cabConsumer.CalculateCostsFromHours(tempoViagemEmSegundos, distanciaViagemEmMetros, horaDeSaida, bandeira1Valor);
        }
    }
}
