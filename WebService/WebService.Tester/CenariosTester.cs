using System;
using System.Collections.Generic;
using System.Text;
using WebService.Business.Consumer;
using WebService.Entities.Consumer;
using WebService.Entities.Enum;

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
                EnderecoOrigem = "Avenida Polonia, 1030 - Sao Geraldo, Porto Alegre - RS",
                EnderecoDestino = "Rua dos Andradas, 736 - Centro Historico, Porto Alegre - RS",
                //PreferenciaUsuario = ePreferences.Duration,
                //TipoTransporte = "driving",
                HorarioSaida = new TimeSpan(10, 0, 0)
            };           

            Cenarios cenario2 = new Cenarios
            {
                CenarioID = 2,
                EnderecoOrigem = "Avenida Polonia, 1030 - Sao Geraldo, Porto Alegre - RS",
                EnderecoDestino = "Rua dos Andradas, 736 - Centro Historico, Porto Alegre - RS",
                //PreferenciaUsuario = ePreferences.Duration,
                //TipoTransporte = "driving",
                HorarioSaida = new TimeSpan(17, 30, 0)
            };

            Cenarios cenario3 = new Cenarios
            {
                CenarioID = 3,
                EnderecoOrigem = "Rua Voluntários da Patria, 1071 - Centro Historico, Porto Alegre - RS",
                EnderecoDestino = "Avenida Julio de Castilhos, 3 - Centro Historico, Porto Alegre - RS",
                //PreferenciaUsuario = ePreferences.Cost,
                //TipoTransporte = "transit",
                HorarioSaida = new TimeSpan(10, 0, 0)
            };

            Cenarios cenario4 = new Cenarios
            {
                CenarioID = 4,
                EnderecoOrigem = "Rua Voluntários da Patria, 1071 - Centro Historico, Porto Alegre - RS",
                EnderecoDestino = "Avenida Julio de Castilhos, 3 - Centro Historico, Porto Alegre - RS",
                //PreferenciaUsuario = ePreferences.Cost,
                //TipoTransporte = "transit",
                HorarioSaida = new TimeSpan(17, 30, 0)
            };

            Cenarios cenario5 = new Cenarios
            {
                CenarioID = 5,
                EnderecoOrigem = "Rua Felizardo, 482 - Jardim Botanico, Porto Alegre - RS",
                EnderecoDestino = "Avenida Plinio Brasil Milano, 1000 - Higienopolis, Porto Alegre - RS",
                //PreferenciaUsuario = ePreferences.Duration,
                //TipoTransporte = "driving",
                HorarioSaida = new TimeSpan(10, 0, 0)
            };

            Cenarios cenario6 = new Cenarios
            {
                CenarioID = 6,
                EnderecoOrigem = "Rua Felizardo, 482 - Jardim Botanico, Porto Alegre - RS",
                EnderecoDestino = "Avenida Plinio Brasil Milano, 1000 - Higienopolis, Porto Alegre - RS",
                //PreferenciaUsuario = ePreferences.Duration,
                //TipoTransporte = "driving",
                HorarioSaida = new TimeSpan(17, 30, 0)
            };

            Cenarios cenario7 = new Cenarios
            {
                CenarioID = 7,
                EnderecoOrigem = "Rua Cidreira, 136 - Ipanema, Porto Alegre - RS",
                EnderecoDestino = "Avenida Icarai, 1088 - Cristal, Porto Alegre - RS",
                //PreferenciaUsuario = ePreferences.Cost,
                //TipoTransporte = "transit",
                HorarioSaida = new TimeSpan(10, 0, 0)
            };

            Cenarios cenario8 = new Cenarios
            {
                CenarioID = 8,
                EnderecoOrigem = "Rua Cidreira, 136 - Ipanema, Porto Alegre - RS",
                EnderecoDestino = "Avenida Icarai, 1088 - Cristal, Porto Alegre - RS",
                //PreferenciaUsuario = ePreferences.Cost,
                //TipoTransporte = "transit",
                HorarioSaida = new TimeSpan(17, 30, 0)
            };

            Cenarios cenario9 = new Cenarios
            {
                CenarioID = 9,
                EnderecoOrigem = "Rua Dr Florencio Ygartua, 238 - Moinhos de Vento, Porto Alegre - RS",
                EnderecoDestino = "Rua Demetrio Ribeiro, 330 - Centro Histórico, Porto Alegre - RS",
                //PreferenciaUsuario = ePreferences.Distance,
                //TipoTransporte = "driving",
                HorarioSaida = new TimeSpan(10, 0, 0)
            };

            Cenarios cenario10 = new Cenarios
            {
                CenarioID = 10,
                EnderecoOrigem = "Rua Dr Florencio Ygartua, 238 - Moinhos de Vento, Porto Alegre - RS",
                EnderecoDestino = "Rua Demetrio Ribeiro, 330 - Centro Histórico, Porto Alegre - RS",
                //PreferenciaUsuario = ePreferences.Distance,
                //TipoTransporte = "driving",
                HorarioSaida = new TimeSpan(17, 30, 0)
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

        public void TestarCenarioPorID(Cenarios cenario)
        {            

        }

    }
}
