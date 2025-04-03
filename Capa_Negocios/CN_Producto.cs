using Capa_Datos;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocios
{
    public class CN_Producto
    {
        private CD_Conexion conexion  = new CD_Conexion();

        public DataTable MostrarDatos()
        {
            DataTable tabla = new DataTable();
            SqlConnection Conn = conexion.AbrirConexion();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Producto", Conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabla); // Llena el DataTable con los datos obtenidos

            conexion.CerrarConexion(); // Cierra la conexión manualmente
            return tabla;
            
        }
    }
}
