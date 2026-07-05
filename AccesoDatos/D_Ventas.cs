using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class D_Ventas
    {
        private ConexionSQL Conexion = new ConexionSQL();

        public int IdVenta { get; set; }
        public string nombre { get; set; }
        public int precioVen { get; set; }
        public int numproVen { get; set; }
        public DateTime fecha { get; set; }
        public int preciototal { get; set; }
        public int pagacon { get; set; }
        public int cambio { get; set; }
        public int IdProducto { get; set; }
        public int IdCliente { get; set; }

        public bool InsertarVentas()
        {
            bool success = false;
            try
            {
                Conexion.abrir();
               

                string sql = "INSERT INTO VENTAS (Nombre, PrecioVen,numProVen,Fecha,precioTotal,pagaCon,Cambio,idProducto,idCliente) VALUES('" + nombre + "', " + precioVen.ToString() + ", " + numproVen.ToString() + ", '" + fecha.Date.ToShortDateString() + "', "
                + preciototal.ToString() + ", " + pagacon.ToString() + ", "
                + cambio.ToString() + ", " + IdProducto.ToString() + ", " + IdCliente.ToString() + ")";


                var cmd = new SqlCommand(sql, Conexion.conectarDB);
                var resultado = cmd.ExecuteNonQuery();
                
                
                
                if (resultado >= 1)
                    success = true;
                
                Conexion.cerrar();

            }
            catch (Exception)
            {
                throw;
            }

            
            return success;
        }

        public DataTable LeerVentas()
        {
            DataTable tablaVentas = new DataTable();

            try
            {
                Conexion.abrir();
                string sql = "SELECT VENTAS.*  FROM VENTAS";

                var cmd = new SqlCommand(sql, Conexion.conectarDB);
                var reader = cmd.ExecuteReader();

                if (reader.HasRows == false)
                    return null;

                tablaVentas.Load(reader);
                Conexion.cerrar();
            }
            catch (Exception)
            {
                throw;
            }
            return tablaVentas;
        }

        public DataTable buscarVentas()
        {
            DataTable tablaVentas = new DataTable();
            try
            {
                Conexion.abrir();

                var cmd = new SqlCommand("SP_BuscarVentas", Conexion.conectarDB);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@BusVentas", nombre);
                var reader = cmd.ExecuteReader();

                if (reader.HasRows == false)
                    return null;

                tablaVentas.Load(reader);
                Conexion.cerrar();
            }
            catch (Exception)
            {
                throw;
            }
            return tablaVentas;
        }

    }
}
