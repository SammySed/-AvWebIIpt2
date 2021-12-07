using AvaliaçãoSistemaWebII.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AvaliaçãoSistemaWebII.Context
{
    public class EFContext : DbContext
    {
        public EFContext() : base("AVSistemasWebII")
        {
            Database.SetInitializer<EFContext>
                (new DropCreateDatabaseIfModelChanges<EFContext>());
        }
        public DbSet<Fornecedor> fornecedor { get; set; }
        public DbSet<Produto> produto { get; set; }        
    }
}