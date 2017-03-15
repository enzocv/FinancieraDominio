using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financiera
{
    /// <summary>
    /// Clase que representa a una Cuenta de Ahorros para un Cliente
    /// </summary>
    class CuentaAhorros
    {
        #region Propiedades         
        /// <summary>
        /// Propiedades
        /// </summary>
        /// <value>
        /// The numero cuenta.
        /// </value>
        public int NumeroCuenta { get; private set; }
        public string CodigoCuenta { get; private set; }
        public decimal SaldoDisponible { get; private set; }
        public int codigoCliente { get; private set; }
        public virtual Cliente Propietario { get; private set; }
        public byte EstadoCuenta { get; private set; }

        #endregion

        #region Constructor        
        /// <summary>
        /// Prevents a default instance of the <see cref="CuentaAhorros"/> class from being created.
        /// </summary>
        private CuentaAhorros()
        {

        }
        #endregion

        #region Metodos        
        /// <summary>
        /// Metodos
        /// </summary>
        /// <param name="as_cod_cuenta">As cod cuenta.</param>
        /// <param name="ao_propietario">The ao propietario.</param>
        /// <returns></returns>
        public static CuentaAhorros Aperturar(string as_cod_cuenta, Cliente ao_propietario)
        {
            
            return new CuentaAhorros()
            {
                CodigoCuenta = as_cod_cuenta,
                SaldoDisponible = 0,
                codigoCliente = ao_propietario.CodigoCliente,
                Propietario = ao_propietario,
                EstadoCuenta = 1
            };
        }

        public void Cancelar()
        {
            SaldoDisponible = 0;
            EstadoCuenta = 5;
        }

        public void Depositar(decimal monto)
        {
            SaldoDisponible += monto;
        }

        public void Retirar(decimal monto)
        {
            SaldoDisponible -= monto;
        }

        #endregion
    }
}
