using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class D_Compras
    {
        private ConexionSQL Conexion = new ConexionSQL();

        public int IdCompras { get; set; }
        public string NomCompra { get; set; }
        public int PrecioCom { get; set; }
        public int numproCom { get; set; }
        public DateTime FechaCompra { get; set; }
        public int TotalCompra { get; set; }
        public int IdProducto { get; set; }
        public int IdProveedor { get; set; }

        public bool InsertarCompras()
        {
            bool success = false;
            try
            {
                Conexion.abrir();


                string sql = "INSERT INTO COMPRAS (nomCompra,precioCom,numProCom,fechaCompra,totalCompra,idProducto,idProveedor) VALUES('" + NomCompra + "', " + PrecioCom.ToString() + ", " + numproCom.ToString() + ", '" + FechaCompra.Date.ToShortDateString() + "', "
                + TotalCompra.ToString() + ", " + IdProducto.ToString() + ", " + IdProveedor.ToString() + ")";
                


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

        public DataTable LeerCompras()
        {
            DataTable tablaCompras = new DataTable();

            try
            {
                Conexion.abrir();
                string sql = "SELECT COMPRAS.*  FROM COMPRAS";

                var cmd = new SqlCommand(sql, Conexion.conectarDB);
                var reader = cmd.ExecuteReader();

                if (reader.HasRows == false)
                    return null;

                tablaCompras.Load(reader);
                Conexion.cerrar();
            }
            catch (Exception)
            {
                throw;
            }
            return tablaCompras;
        }
    }
}
