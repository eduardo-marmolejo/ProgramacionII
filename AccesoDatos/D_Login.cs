using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class D_Login
    {
        private ConexionSQL Conexion = new ConexionSQL();

        public int IdLogin { get; set; }
        public string usuario { get; set; }
        public string contraseña { get; set; }


        public bool Entrar()
        {
            bool success = false;
            try
            {
                Conexion.abrir();

                string sql = "SELECT idLogin,Usuario,Contraseña FROM LOGIN WHERE Usuario='" + usuario + "' AND Contraseña='";
                sql += contraseña + "'";



                var cmd = new SqlCommand(sql, Conexion.conectarDB);

                cmd.Parameters.Add(new SqlParameter("Usuario", usuario));
                cmd.Parameters.Add(new SqlParameter("Contraseña", contraseña));

                var resultado = cmd.ExecuteReader();

                

                if (resultado.HasRows == true)
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
