using System;
using System.Collections.Generic;
using System.Text;

namespace WebService.Consuming
{
    public class CabConsumer
    {
        public double CalculateCostsFromHours(int tempoViagemEmSegundos, int distanciaViagemEmMetros, TimeSpan horaDeSaida, double bandeira1Valor)
        {
            double valorInicial = 3.50;

            TimeSpan bandeira1Inicio = new TimeSpan(6, 0, 0);
            TimeSpan bandeira1Fim = new TimeSpan(20, 0, 0);

            double valorKmPercorrido = distanciaViagemEmMetros / 1000;
            double valor = (valorKmPercorrido * bandeira1Valor) + valorInicial;

            if (horaDeSaida >= bandeira1Inicio && horaDeSaida <= bandeira1Fim)            
                return valor;                            
            else            
                return valor += valor * 0.2;
        }
    }
}
