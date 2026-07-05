using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class D_Productos
    {
        private ConexionSQL Conexion = new ConexionSQL();

        public int IdProductos { get; set; }
        public string nombre { get; set; }
        public int precio { get; set; }
        public int stock { get; set; }

        public bool Insertar()
        {
            bool success = false;
            try
            {
                Conexion.abrir();

                string sql = "INSERT INTO PRODUCTOS VALUES('" + nombre + "', ";
                sql += precio.ToString() + ", " + stock.ToString() + ")";

                var cmd = new SqlCommand(sql, Conexion.conectarDB);
                var resultado = cmd.ExecuteNonQuery();

                if (resultado == 1)
                    success = true;

                Conexion.cerrar();

            }
            catch (Exception)
            {
                throw;
            }
            
            return success;
        }

        public DataTable LeerProductos()
        {
            DataTable tablaProductos = new DataTable();

            try
            {
                Conexion.abrir();
                string sql = "SELECT PRODUCTOS.*  FROM PRODUCTOS";

                var cmd = new SqlCommand(sql, Conexion.conectarDB);
                var reader = cmd.ExecuteReader();

                if (reader.HasRows == false)
                    return null;
                
                tablaProductos.Load(reader);
                Conexion.cerrar();
            }
            catch (Exception)
            {
                throw;
            }
            return tablaProductos;
        }

        public bool Actualizar()
        {
            bool success = false;
            try
            {
                //Consultar de UPDATE
                Conexion.abrir();

                /*string sql = "UPDATE PRODUCTOS SET Nombre='" + nombre + "', Precio='" + precio.ToString();
                sql += "', Stock='" + stock.ToString() + "' WHERE idProducto=" + IdProductos.ToString();
                */

                var cmd = new SqlCommand("SP_ActualizarProductos", Conexion.conectarDB);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@idProducto", IdProductos);
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@Precio", precio);
                cmd.Parameters.AddWithValue("@Stock", stock);

                var resultado = cmd.ExecuteNonQuery();

                if (resultado == 1)
                    success = true;

                Conexion.cerrar();
            }
            catch(Exception)
            {
                throw;
            }
            return success;
        }

        public DataTable buscarProductos()
        {
            DataTable tablaProductos = new DataTable();
            try
            {
                Conexion.abrir();

               /* SqlCommand sql = new SqlCommand("BuscarProductos", Conexion.conectarDB);
                sql.CommandType = CommandType.StoredProcedure;
                sql.Parameters.Add("@BusProductos", SqlDbType.VarChar, 200).Value = BusNombrePro;

               /* string sql = "SELECT  PRODUCTOS.idProducto AS IdProductos, PRODUCTOS.Nombre AS nombre, PRODUCTOS.Precio AS precio, PRODUCTOS.Stock AS stock FROM PRODUCTOS";
               */
                var cmd = new SqlCommand("BuscarProductos", Conexion.conectarDB);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@BusProductos", nombre);
                var reader = cmd.ExecuteReader();

                if (reader.HasRows == false)
                    return null;

                tablaProductos.Load(reader);
                Conexion.cerrar();
            }
            catch (Exception)
            {
                throw;
            }
            return tablaProductos;
        }

        public bool Borrar()
        {
            bool success = false;
            try
            {
                Conexion.abrir();

                string sql = "DELETE FROM PRODUCTOS WHERE idProducto=idProducto";

                var cmd = new SqlCommand(sql, Conexion.conectarDB);
                var resultado = cmd.ExecuteNonQuery();

                if (resultado == 1)
                    success = true;

                Conexion.cerrar();
            }
            catch (Exception)
            {
                throw;
            }

            return success;
        }
    }
}
