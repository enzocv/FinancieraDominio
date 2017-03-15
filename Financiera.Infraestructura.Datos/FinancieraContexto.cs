using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Financiera.Infraestructura.Datos.Mapeos;

namespace Financiera.Infraestructura.Datos
{
    public class FinancieraContexto : DbContext
    {
        public FinancieraContexto()  :  base("CadenaDeConexion")
        {
            Database.SetInitializer<FinancieraContexto>(null);
        }

        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<CuentaAhorros> Cuntas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new ClienteMapeo());
            modelBuilder.Configurations.Add(new CuentaAhorrosMapeo());
        }

    }
}
