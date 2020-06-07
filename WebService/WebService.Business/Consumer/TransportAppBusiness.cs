using System;
using System.Collections.Generic;
using System.Text;
using WebService.Consuming;

namespace WebService.Business.Consumer
{
    public class TransportAppBusiness
    {
        public double GetCosts(int tempoViagemEmSegundos, int distanciaViagemEmMetros)
        {
            TransportAppConsumer transportAppConsumer = new TransportAppConsumer();
            double tempoViagemEmMinutos = tempoViagemEmSegundos / 60;
            double distanciaViagemEmKm = distanciaViagemEmMetros / 1000;

            return transportAppConsumer.CalculateCostFromTimeAndDistance(tempoViagemEmMinutos, distanciaViagemEmKm);
        }
    }
}
