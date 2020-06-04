using System;
using System.Collections.Generic;
using System.Text;

namespace WebService.Consuming
{
    public class TransportAppConsumer
    {
        public double CalculateCostFromTimeAndDistance(int tempoDeViagem, int distanciaDeViagem)
        {
            double valorInicial = 2.30;
            double custoFixo = 0.75;
            double taxaPorMinuto = 0.20;
            double taxaPorKm = 1.21;

            double precoMinimo = 6.94;

            double valorKmPercorrido = (double)tempoDeViagem * taxaPorMinuto;
            double valorDuracaoViagemPorMinuto = (double)distanciaDeViagem * taxaPorKm;

            double custoTotal = valorInicial + custoFixo + valorDuracaoViagemPorMinuto + valorKmPercorrido;

            if (custoTotal < precoMinimo)
                return precoMinimo;
            else
                return custoTotal;
        }
    }
}
