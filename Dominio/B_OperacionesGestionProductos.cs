using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace Business
{
    public class B_OperacionesGestionProductos
    {
        public D_Productos dProductos = new D_Productos();

        public string insertarProductos(int idProducto, string Nombre, int Precio, int Stock)
        {
            try
            {
                dProductos.IdProductos = idProducto;
                dProductos.nombre = Nombre;
                dProductos.precio = Precio;
                dProductos.stock = Stock;

                if(dProductos.Insertar())
                    return "El producto ha sido dada de alta correctamente";
                else
                    return "El producto no ha sido dada de alta";
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable cargarProductos()
        {
            try
            {
                return dProductos.LeerProductos();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public string actualizarProducto(int idProducto, string Nombre, int Precio, int Stock)
        {
            try
            {
                dProductos.IdProductos = idProducto;
                dProductos.nombre = Nombre;
                dProductos.precio = Precio;
                dProductos.stock = Stock;

                if (dProductos.Actualizar())
                    return "El producto se actualizó correctamente";
                else
                    return "El producto no fue actualizado";
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable busquedaProductos(string Nombre)
        {
            try
            {
                dProductos.nombre = Nombre;
                return dProductos.buscarProductos();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public string EliminarProductos(int idProducto, string Nombre, int Precio, int Stock)
        {
            try
            {
                dProductos.IdProductos = idProducto;
                dProductos.nombre = Nombre;
                dProductos.precio = Precio;
                dProductos.stock = Stock;

                if (dProductos.Borrar())
                    return "El producto se ha eliminado";
                else
                    return "El producto no se eliminó";
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
