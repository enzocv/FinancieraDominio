﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financiera
{
    /// <summary>
    /// Clase que representa a un Cliente
    /// </summary>
    public class Cliente
    {
        #region Propiedades
        public int CodigoCliente { get;private set; }
        public string NombreCliente { get; private set; }
        public DateTime FechaNacimiento { get; private set; }
        #endregion

        #region Constructor
        private Cliente()
        {

        }
        #endregion

        #region Metodos
        public static Cliente Crear(int ai_cod_cliente, string as_nom_cliente, DateTime adt_fec_nacimiento)
        {
            return new Cliente()
            {
                CodigoCliente = ai_cod_cliente,
                NombreCliente = as_nom_cliente,
                FechaNacimiento = adt_fec_nacimiento
             };
        }

        public void ModificarNombre(string as_nuevo_nombre)
        {
            NombreCliente = as_nuevo_nombre;
        }
     }
    #endregion
}
