using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL
{
    public class ConexionSQL
    {
        //Cadena de conexión
        private readonly string CADENA = "Data Source=LAPTOP-J2A28JHM;Initial Catalog=REFACCIONARIA;Integrated Security=True";

        //Objeto conexión
        public SqlConnection conectarDB = new SqlConnection();
        
        //Contructor
        public ConexionSQL()
        {
            conectarDB.ConnectionString = CADENA;
        }

        public void abrir()
        {
            try
            {
                conectarDB.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al abrir la Base de Datos"+ ex.Message);
            }
        }

        public void cerrar()
        {
            conectarDB.Close();
        }
    }
}
