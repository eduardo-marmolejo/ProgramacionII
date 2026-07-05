using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace Business
{
    public class B_OperacionesGestionClientes
    {
        public D_Clientes dClientes = new D_Clientes();

        public string insertarClientes(int idCliente, string nomCliente, string apPaterno, string apMaterno, string telCliente, int Descuentos, int compraTotal)
        {
            try
            {
                dClientes.IdCliente = idCliente;
                dClientes.NomCliente = nomCliente;
                dClientes.ApPaterno = apPaterno;
                dClientes.ApMaterno = apMaterno;
                dClientes.TelCliente = telCliente;
                dClientes.descuentos = Descuentos;
                dClientes.compratotal = compraTotal;

                if (dClientes.InsertarClientes())
                    return "El Cliente ha sido dado de alta correctamente";
                else
                    return "El Cliente no ha sido dado de alta";
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable cargarClientes()
        {
            try
            {
                return dClientes.LeerClientes();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public string actualizarClientes(int idCliente, string nomCliente, string apPaterno, string apMaterno, string telCliente, int Descuentos, int compraTotal)
        {
            try
            {
                dClientes.IdCliente = idCliente;
                dClientes.NomCliente = nomCliente;
                dClientes.ApPaterno = apPaterno;
                dClientes.ApMaterno = apMaterno;
                dClientes.TelCliente = telCliente;
                dClientes.descuentos = Descuentos;
                dClientes.compratotal = compraTotal;

                if (dClientes.ActualizarClientes())
                    return "Los datos del cliente se actualizaron correctamente";
                else
                    return "Los datos del cliente no se actualizaron correctamente";
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable busquedaClientes(string nomcliente)
        {
            try
            {
                dClientes.NomCliente = nomcliente;
                return dClientes.buscarClientes();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public string EliminarClientes(int idCliente, string nomCliente, string apPaterno, string apMaterno, string telCliente, int Descuentos, int compraTotal)
        {
            try
            {
                dClientes.IdCliente = idCliente;
                dClientes.NomCliente = nomCliente;
                dClientes.ApPaterno = apPaterno;
                dClientes.ApMaterno = apMaterno;
                dClientes.TelCliente = telCliente;
                dClientes.descuentos = Descuentos;
                dClientes.compratotal = compraTotal;

                if (dClientes.BorrarClientes())
                    return "El cliente se ha eliminado";
                else
                    return "El cliente no se eliminó";
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
