using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class B_OperacionesGestionCompras
    {
        public D_Compras dCompras = new D_Compras();

        public string insertarCompras(int idCompra, string nomCompra, int precioCom, int numProCom, DateTime fechaCompra, int totalCompra, int idProducto, int idProveedor)
        {
            try
            {
                dCompras.IdCompras = idCompra;
                dCompras.NomCompra = nomCompra;
                dCompras.PrecioCom = precioCom;
                dCompras.numproCom = numProCom;
                dCompras.FechaCompra = fechaCompra;
                dCompras.TotalCompra = totalCompra;
                dCompras.IdProducto = idProducto;
                dCompras.IdProveedor = idProveedor;




                if (dCompras.InsertarCompras())
                    return "La compra ha sido realizada correctamente";
                else
                    return "La compra no ha sido realizada correctamente";

            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable cargarCompras()
        {
            try
            {
                return dCompras.LeerCompras();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
