using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebService.Entities;

namespace WebService.DataAccess.Repository.Context
{
    public class WebServiceContext : DbContext
    {
        public WebServiceContext(DbContextOptions<WebServiceContext> options) : base(options)
        {

        }

        public DbSet<AppUser> AppUser { get; set; }
        public DbSet<Contatos> Contatos { get; set; }
        public DbSet<Enderecos> Enderecos { get; set; }
        public DbSet<Estacionamento> Estacionamento { get; set; }
        public DbSet<EstacionamentoFluxo> EstacionamentoFluxo { get; set; }
        public DbSet<EstacionamentoValores> EstacionamentoValores { get; set; }
        public DbSet<Locacao> Locacao { get; set; }
        public DbSet<Motorista> Motorista { get; set; }
        public DbSet<MotoristaPreferencias> MotoristaPreferencias { get; set; }
        public DbSet<MotoristaVeiculos> MotoristaVeiculos { get; set; }

    }
}
