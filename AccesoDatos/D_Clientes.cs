using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class D_Clientes
    {
        private ConexionSQL Conexion = new ConexionSQL();

        public int IdCliente { get; set; }
        public string NomCliente { get; set; }
        public string ApPaterno { get; set; }
        public string ApMaterno { get; set; }
        public string TelCliente { get; set; }
        public int descuentos { get; set; }
        public int compratotal { get; set; }

        public bool InsertarClientes()
        {
            bool success = false;
            try
            {
                Conexion.abrir();

                string sql = "INSERT INTO CLIENTES VALUES('" + NomCliente + "', '" + ApPaterno + "', '" + ApMaterno + "', '" + TelCliente + "', ";
                sql += descuentos.ToString() + ", " + compratotal.ToString() + ")";

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

        public DataTable LeerClientes()
        {
            DataTable tablaClientes = new DataTable();

            try
            {
                Conexion.abrir();
                string sql = "SELECT CLIENTES.*  FROM CLIENTES";

                var cmd = new SqlCommand(sql, Conexion.conectarDB);
                var reader = cmd.ExecuteReader();

                if (reader.HasRows == false)
                    return null;

                tablaClientes.Load(reader);
                Conexion.cerrar();
            }
            catch (Exception)
            {
                throw;
            }
            return tablaClientes;
        }

        public bool ActualizarClientes()
        {
            bool success = false;
            try
            {
                //Consultar de UPDATE
                Conexion.abrir();

                var cmd = new SqlCommand("SP_ActualizarClientes", Conexion.conectarDB);
                cmd.CommandType = CommandType.StoredProcedure;
                
                cmd.Parameters.AddWithValue("@idCliente", IdCliente);
                cmd.Parameters.AddWithValue("@nomCliente", NomCliente);
                cmd.Parameters.AddWithValue("@apPaterno", ApPaterno);
                cmd.Parameters.AddWithValue("@apMaterno", ApMaterno);
                cmd.Parameters.AddWithValue("@telCliente", TelCliente);
                cmd.Parameters.AddWithValue("@Descuentos", descuentos);
                cmd.Parameters.AddWithValue("@compraTotal", compratotal);


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

        public DataTable buscarClientes()
        {
            DataTable tablaClientes = new DataTable();
            try
            {
                Conexion.abrir();

                var cmd = new SqlCommand("BuscarClientes", Conexion.conectarDB);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@BusClientes", NomCliente);
                var reader = cmd.ExecuteReader();

                if (reader.HasRows == false)
                    return null;

                tablaClientes.Load(reader);
                Conexion.cerrar();
            }
            catch (Exception)
            {
                throw;
            }
            return tablaClientes;
        }

        public bool BorrarClientes()
        {
            bool success = false;
            try
            {
                Conexion.abrir();

                string sql = "DELETE FROM CLIENTES WHERE idCliente=idCliente";

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
