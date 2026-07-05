using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace Business
{
    public class B_OperacionesGestionVentas
    {
        public D_Ventas dVentas = new D_Ventas();

        public string insertarVentas(int idVenta, string Nombre, int PrecioVen, int numProVen, DateTime Fecha, int precioTotal, int pagaCon, int Cambio, int idProducto, int idCliente)
        {
            try
            {
                dVentas.IdVenta = idVenta;
                dVentas.nombre = Nombre;
                dVentas.precioVen = PrecioVen;
                dVentas.numproVen = numProVen;
                dVentas.fecha = Fecha;
                dVentas.preciototal = precioTotal;
                dVentas.pagacon = pagaCon;
                dVentas.cambio = Cambio;
                dVentas.IdProducto = idProducto;
                dVentas.IdCliente = idCliente;

              
               
                
                if (dVentas.InsertarVentas())
                    return "La venta ha sido dada de alta correctamente";
                else
                    return "La venta no ha sido dada de alta";
                
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable cargarventas()
        {
            try
            {
                return dVentas.LeerVentas();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable busquedaVentas(string Nombre)
        {
            try
            {
                dVentas.nombre = Nombre;
                return dVentas.buscarVentas();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
