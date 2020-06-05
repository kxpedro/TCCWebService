using System;
using System.Collections.Generic;
using System.Text;
using WebService.Entities;

namespace WebService.Tester
{
    public class EstacionamentoTester
    {
        public List<Estacionamento> CriaEstacionamentosParaTeste()
        {
            List<Estacionamento> lsEstacionamentos = new List<Estacionamento>();

            //

            Estacionamento estacionamento1 = new Estacionamento();
            estacionamento1.EstacionamentoID = 1;
            estacionamento1.Endereco = new Enderecos 
            {
                Rua = "Rua Riachuelo",
                Numero = "1323",
                Bairro = "Centro Historico",
                Cidade = "Porto Alegre",
                Estado = "RS",
                CEP = "90010271",
                Complemento = ""
            };
            estacionamento1.CNPJ = "";
            estacionamento1.NomeFantasia = "Safe Park";
            estacionamento1.Vagas = 15;

            lsEstacionamentos.Add(estacionamento1);

            //

            Estacionamento estacionamento2 = new Estacionamento();
            estacionamento2.EstacionamentoID = 2;
            estacionamento2.Endereco = new Enderecos
            {
                Rua = "Avenida Padre Cacique",
                Numero = "128",
                Bairro = "Menino Deus",
                Cidade = "Porto Alegre",
                Estado = "RS",
                CEP = "90840690",
                Complemento = ""
            };
            estacionamento2.CNPJ = "";
            estacionamento2.NomeFantasia = "Jerônimo Estacionamento";
            estacionamento2.Vagas = 5;

            lsEstacionamentos.Add(estacionamento2);

            //

            Estacionamento estacionamento3 = new Estacionamento();
            estacionamento3.EstacionamentoID = 3;
            estacionamento3.Endereco = new Enderecos
            {
                Rua = "Rua Sr dos Passos",
                Numero = "225",
                Bairro = "Centro Historico",
                Cidade = "Porto Alegre",
                Estado = "RS",
                CEP = "90020180",
                Complemento = ""
            };
            estacionamento3.CNPJ = "";
            estacionamento3.NomeFantasia = "Estacionamento Indigo Senhor dos Passos";
            estacionamento3.Vagas = 2;

            lsEstacionamentos.Add(estacionamento3);

            return lsEstacionamentos;
        }
    }
}
