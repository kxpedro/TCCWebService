using System;
using System.Collections.Generic;
using System.Text;
using WebService.Business.Consumer;
using WebService.Entities.Consumer;

namespace WebService.Tester
{
    public class CenariosTester
    {        
        public List<Cenarios> CriarCenariosParaTeste()
        {
            List<Cenarios> lsCenarios = new List<Cenarios>();

            Cenarios cenario1 = new Cenarios
            {
                CenarioID = 1,
                EnderecoOrigem = "",
                EnderecoDestino = "",
                PreferenciaUsuario = "",
                TipoTransporte = "",
                HorarioSaida = new TimeSpan(12, 0, 0)
            };           

            Cenarios cenario2 = new Cenarios
            {
                CenarioID = 2,
                EnderecoOrigem = "",
                EnderecoDestino = "",
                PreferenciaUsuario = "",
                TipoTransporte = "",
                HorarioSaida = new TimeSpan(12, 0, 0)
            };

            Cenarios cenario3 = new Cenarios
            {
                CenarioID = 3,
                EnderecoOrigem = "",
                EnderecoDestino = "",
                PreferenciaUsuario = "",
                TipoTransporte = "",
                HorarioSaida = new TimeSpan(12, 0, 0)
            };

            Cenarios cenario4 = new Cenarios
            {
                CenarioID = 4,
                EnderecoOrigem = "",
                EnderecoDestino = "",
                PreferenciaUsuario = "",
                TipoTransporte = "",
                HorarioSaida = new TimeSpan(12, 0, 0)
            };

            Cenarios cenario5 = new Cenarios
            {
                CenarioID = 5,
                EnderecoOrigem = "",
                EnderecoDestino = "",
                PreferenciaUsuario = "",
                TipoTransporte = "",
                HorarioSaida = new TimeSpan(12, 0, 0)
            };

            Cenarios cenario6 = new Cenarios
            {
                CenarioID = 6,
                EnderecoOrigem = "",
                EnderecoDestino = "",
                PreferenciaUsuario = "",
                TipoTransporte = "",
                HorarioSaida = new TimeSpan(12, 0, 0)
            };

            Cenarios cenario7 = new Cenarios
            {
                CenarioID = 7,
                EnderecoOrigem = "",
                EnderecoDestino = "",
                PreferenciaUsuario = "",
                TipoTransporte = "",
                HorarioSaida = new TimeSpan(12, 0, 0)
            };

            Cenarios cenario8 = new Cenarios
            {
                CenarioID = 8,
                EnderecoOrigem = "",
                EnderecoDestino = "",
                PreferenciaUsuario = "",
                TipoTransporte = "",
                HorarioSaida = new TimeSpan(12, 0, 0)
            };

            Cenarios cenario9 = new Cenarios
            {
                CenarioID = 9,
                EnderecoOrigem = "",
                EnderecoDestino = "",
                PreferenciaUsuario = "",
                TipoTransporte = "",
                HorarioSaida = new TimeSpan(12, 0, 0)
            };

            Cenarios cenario10 = new Cenarios
            {
                CenarioID = 10,
                EnderecoOrigem = "",
                EnderecoDestino = "",
                PreferenciaUsuario = "",
                TipoTransporte = "",
                HorarioSaida = new TimeSpan(12, 0, 0)
            };

            lsCenarios.Add(cenario1);
            lsCenarios.Add(cenario2);
            lsCenarios.Add(cenario3);
            lsCenarios.Add(cenario4);
            lsCenarios.Add(cenario5);
            lsCenarios.Add(cenario6);
            lsCenarios.Add(cenario7);
            lsCenarios.Add(cenario8);
            lsCenarios.Add(cenario9);
            lsCenarios.Add(cenario10);

            return lsCenarios;
        }

        public void TestarCenarioPorID(int cenarioId)
        {            

        }

    }
}
