using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using DAL;
using System;

namespace Business
{
    public class B_OperacionesGestionLogin
    {
        public D_Login dLogin = new D_Login();

        public string Entrar(int idLogin, string Usuario, string Contraseña)
        {
            try
            {
                dLogin.IdLogin= idLogin;
                dLogin.usuario = Usuario;
                dLogin.contraseña = Contraseña;

                if (dLogin.Entrar())
                    return "Se ha iniciado sesión correctamente";
                else
                    return "Error de inicio de sesión";
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
