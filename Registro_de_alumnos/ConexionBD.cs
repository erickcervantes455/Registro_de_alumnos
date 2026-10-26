using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Text;

namespace Registro_de_alumnos
{
    public static class ConexionBD
    {
        public static OleDbConnection ObtenerConexion()
        {
            string rutaDB = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "Datos",
                "Escuela.accdb"
                );
            string cadenaConexion = 
                $"Provider=Microsoft.ACE.OLEDB.12.0;"+
                $"Data source={rutaDB}";

            return new OleDbConnection(cadenaConexion);
        }
    }
}
