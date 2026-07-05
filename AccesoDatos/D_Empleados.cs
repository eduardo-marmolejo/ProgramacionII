using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class D_Empleados
    {
        private ConexionSQL Conexion = new ConexionSQL();

        public int IdEmpleado { get; set; }
        public string NomEmpleado { get; set; }
        public string ApPaterno { get; set; }
        public string ApMaterno { get; set; }
        public string curp { get; set; }
        public string TelEmpleado { get; set; }
        public int IdLogin { get; set; }
        public int IdDireccion { get; set; }

        public bool InsertarEmpleados()
        {
            bool success = false;
            try
            {
                Conexion.abrir();

                string sql = "INSERT INTO EMPLEADOS VALUES('" + NomEmpleado + "', '" + ApPaterno + "', '" + ApMaterno + "', '" + curp + "', '"; 
                sql += TelEmpleado + "', "+ IdLogin.ToString() + ", " + IdDireccion.ToString() + ")";

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

        public DataTable LeerEmpleados()
        {
            DataTable tablaEmpleados = new DataTable();

            try
            {
                Conexion.abrir();
                string sql = "SELECT EMPLEADOS.*  FROM EMPLEADOS";

                var cmd = new SqlCommand(sql, Conexion.conectarDB);
                var reader = cmd.ExecuteReader();

                if (reader.HasRows == false)
                    return null;

                tablaEmpleados.Load(reader);
                Conexion.cerrar();
            }
            catch (Exception)
            {
                throw;
            }
            return tablaEmpleados;
        }

        public bool ActualizarEmpleados()
        {
            bool success = false;
            try
            {
                //Consultar de UPDATE
                Conexion.abrir();

                var cmd = new SqlCommand("SP_ActualizarEmpleados", Conexion.conectarDB);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@idEmpleado", IdEmpleado);
                cmd.Parameters.AddWithValue("@nomEmpleado", NomEmpleado);
                cmd.Parameters.AddWithValue("@apPaterno", ApPaterno);
                cmd.Parameters.AddWithValue("@apMaterno", ApMaterno);
                cmd.Parameters.AddWithValue("@CURP", curp);
                cmd.Parameters.AddWithValue("@telEmpleado", TelEmpleado);
                cmd.Parameters.AddWithValue("@idLogin", IdLogin);
                cmd.Parameters.AddWithValue("@idDireccion", IdDireccion);

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

        public DataTable buscarEmpleados()
        {
            DataTable tablaEmpleados = new DataTable();
            try
            {
                Conexion.abrir();

                var cmd = new SqlCommand("BuscarEmpleados", Conexion.conectarDB);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@BusEmpleados", NomEmpleado);
                var reader = cmd.ExecuteReader();

                if (reader.HasRows == false)
                    return null;

                tablaEmpleados.Load(reader);
                Conexion.cerrar();
            }
            catch (Exception)
            {
                throw;
            }
            return tablaEmpleados;
        }

        public bool BorrarEmpleados()
        {
            bool success = false;
            try
            {
                Conexion.abrir();

                string sql = "DELETE FROM EMPLEADOS WHERE idEmpledo=idEmpleado";

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
