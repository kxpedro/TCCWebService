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

            Estacionamento estacionamento = new Estacionamento();
            estacionamento.EstacionamentoID = 1;
            estacionamento.Endereco = new Enderecos 
            {
                Rua = "",
                Numero = "",
                Bairro = "",
                Cidade = "",
                Estado = "",
                CEP = "",
                Complemento = ""
            };
            estacionamento.CNPJ = "";
            estacionamento.NomeFantasia = "";

            lsEstacionamentos.Add(estacionamento);

            return lsEstacionamentos;
        }
    }
}
