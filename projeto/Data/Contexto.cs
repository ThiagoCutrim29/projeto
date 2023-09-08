using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using projeto.Models;
using System.Collections.Generic;

namespace projeto.Data
{
    public class Contexto : DbContext

    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }
        public DbSet<DemandaModel> Demandas { get; set; }

    }
}
