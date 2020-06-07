using System;
using System.Collections.Generic;
using System.Text;

namespace WebService.Consuming
{
    public class TransportAppConsumer
    {
        public double CalculateCostFromTimeAndDistance(double tempoDeViagem, double distanciaDeViagem)
        {
            double valorInicial = 2.30;
            double custoFixo = 0.75;
            double taxaPorMinuto = 0.20;
            double taxaPorKm = 1.21;

            double precoMinimo = 6.94;

            double valorKmPercorrido = tempoDeViagem * taxaPorMinuto;
            double valorDuracaoViagemPorMinuto = distanciaDeViagem * taxaPorKm;

            double custoTotal = valorInicial + custoFixo + valorDuracaoViagemPorMinuto + valorKmPercorrido;

            if (custoTotal < precoMinimo)
                return precoMinimo;
            else
                return custoTotal;
        }
    }
}
