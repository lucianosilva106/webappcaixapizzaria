using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webappcaixapizzaria.Model;

namespace webappcaixapizzaria.Configuracao
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

            Database.EnsureCreated();
        }

        public DbSet<Funcionario> Funcionario { get; set; }
        public DbSet<Caixacontrole> Caixacontrole { get; set; }
        public DbSet<Caixalancamento> Caixalancamento { get; set; }
        public DbSet<Formapagamento> FormaPagamento { get; set; }
    }
}
