using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjetoWEBMVC_CSharp_Nelio.Models;

namespace ProjetoWEBMVC_CSharp_Nelio.Data
{
    public class ProjetoWEBMVC_CSharp_NelioContext : DbContext
    {
        public ProjetoWEBMVC_CSharp_NelioContext (DbContextOptions<ProjetoWEBMVC_CSharp_NelioContext> options)
            : base(options)
        {
        }

        public DbSet<ProjetoWEBMVC_CSharp_Nelio.Models.Departament> Departament { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecords> SalesRecord { get; set; }
    }
}
