using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebService.Models;

namespace WebService.Repository
{
    public class WebServiceContext : DbContext
    {
        public WebServiceContext(DbContextOptions<WebServiceContext> options) : base(options)
        {

        }

        public DbSet<Motorista> Motorista { get; set; }
    }
}
