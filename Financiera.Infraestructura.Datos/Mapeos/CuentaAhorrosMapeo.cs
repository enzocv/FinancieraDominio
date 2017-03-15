﻿using Financiera.Infraestructura.Datos.Mapeos;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Financiera.Infraestructura.Datos.Mapeos
{
    public class CuentaAhorrosMapeo : EntityTypeConfiguration<CuentaAhorros>
    {
        public CuentaAhorrosMapeo()
        {
            ToTable("CUENTA_AHORROS", "FI");
            HasKey(k => k.NumeroCuenta);
            Property(p => p.NumeroCuenta).HasColumnName("NUM_CUENTA").IsRequired();
            Property(p => p.CodigoCuenta).HasColumnName("COD_CUENTA").IsRequired();
            Property(p => p.SaldoDisponible).HasColumnName("SAL_DISPONIBLE").IsRequired();
            Property(p => p.EstadoCuenta).HasColumnName("EST_CUENTA").IsRequired();
            Property(p => p.codigoCliente).HasColumnName("COD_CLIENTE").IsRequired();
            HasRequired(m => m.Propietario).WithMany().HasForeignKey(f => f.codigoCliente);
        }
    }
}
