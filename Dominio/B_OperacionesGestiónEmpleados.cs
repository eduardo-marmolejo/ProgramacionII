using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace Business
{
    public class B_OperacionesGestiónEmpleados
    {
        public D_Empleados dEmpleados = new D_Empleados();

        public string insertarEmpleados(int idEmpleado, string nomEmpleado, string apPaterno, string apMaterno, string CURP, string telEmpleado, int idLogin, int idDireccion)
        {
            try
            {
                dEmpleados.IdEmpleado = idEmpleado;
                dEmpleados.NomEmpleado = nomEmpleado;
                dEmpleados.ApPaterno = apPaterno;
                dEmpleados.ApMaterno = apMaterno;
                dEmpleados.curp = CURP;
                dEmpleados.TelEmpleado = telEmpleado;
                dEmpleados.IdLogin = idLogin;
                dEmpleados.IdDireccion = idDireccion;

                if (dEmpleados.InsertarEmpleados())
                    return "El empleado se ha sido dado de alta correctamente";
                else
                    return "El empleado no se ha sido dado de alta correctamente";
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable cargarEmpleados()
        {
            try
            {
                return dEmpleados.LeerEmpleados();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public string actualizarEmpleados(int idEmpleado, string nomEmpleado, string apPaterno, string apMaterno, string CURP, string telEmpleado, int idLogin, int idDireccion)
        {
            try
            {
                dEmpleados.IdEmpleado = idEmpleado;
                dEmpleados.NomEmpleado = nomEmpleado;
                dEmpleados.ApPaterno = apPaterno;
                dEmpleados.ApMaterno = apMaterno;
                dEmpleados.curp = CURP;
                dEmpleados.TelEmpleado = telEmpleado;
                dEmpleados.IdLogin = idLogin;
                dEmpleados.IdDireccion = idDireccion;

                if (dEmpleados.ActualizarEmpleados())
                    return "Los datos del empleado se actualizaron correctamente";
                else
                    return "Los datos del empleado no se actualizaron correctamente";
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable busquedaEmpleados(string nomEmpleado)
        {
            try
            {
                dEmpleados.NomEmpleado= nomEmpleado;
                return dEmpleados.buscarEmpleados();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public string EliminarEmpleados(int idEmpleado, string nomEmpleado, string apPaterno, string apMaterno, string CURP, string telEmpleado, int idLogin, int idDireccion)
        {
            try
            {
                dEmpleados.IdEmpleado = idEmpleado;
                dEmpleados.NomEmpleado = nomEmpleado;
                dEmpleados.ApPaterno = apPaterno;
                dEmpleados.ApMaterno = apMaterno;
                dEmpleados.curp = CURP;
                dEmpleados.TelEmpleado = telEmpleado;
                dEmpleados.IdLogin = idLogin;
                dEmpleados.IdDireccion = idDireccion;

                if (dEmpleados.BorrarEmpleados())
                    return "El empleado se ha eliminado";
                else
                    return "El empleado no se eliminó";
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
