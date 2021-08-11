using ProdCad.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdCad.Context
{
    class BaseContext : DbContext
    {
        public DbSet<Produtos> Produtos { get; set; }
        public DbSet<Categorias> Categorias{ get; set; }
        public BaseContext() : base ("ProdCatDB")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
