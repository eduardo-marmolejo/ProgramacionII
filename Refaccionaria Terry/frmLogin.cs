using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using DAL;
using Business;
using System.Data.SqlClient;

namespace Refaccionaria_Terry
{
    public partial class frmLogin : Form
    {
        private B_OperacionesGestionLogin b_OperacionesGestionLogin = new B_OperacionesGestionLogin();

        String Usuario, Contraseña;
        int idLogin;



        public frmLogin()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        private void txtUsuario_Enter(object sender, EventArgs e)
        {
           if (txtUsuario.Text == "USUARIO")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.White;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO";
                txtUsuario.ForeColor = Color.White;
            }
        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "CONTRASEÑA")
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.White;
                txtContraseña.UseSystemPasswordChar = true;
            }
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                txtContraseña.Text = "CONTRASEÑA";
                txtContraseña.ForeColor = Color.White;
                txtContraseña.UseSystemPasswordChar = false;
            }
        }

        private void pbCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbMinizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void frmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            Conversiones();

            string respuesta = b_OperacionesGestionLogin.Entrar(1, Usuario, Contraseña);
            
            if (respuesta == "Se ha iniciado sesión correctamente") {
                MessageBox.Show(respuesta);
                this.Hide();

                frmInicio formIni = new frmInicio();

                formIni.Show();
            }
            else
            {
                //MessageBox.Show(respuesta);
                MessageBox.Show("Datos incorrectos, puede que el usuario y contraseña ingresados sean erróneos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            Conversiones();

            string respuesta = b_OperacionesGestionLogin.Entrar(1, Usuario, Contraseña);

            /*if (respuesta == "Se ha iniciado sesión correctamente")
            {
                MessageBox.Show(respuesta);
                this.Hide();

                frmInicio formIni = new frmInicio();

                formIni.Show();
            }
            else
            {
                //MessageBox.Show(respuesta);
                MessageBox.Show("Datos incorrectos, puede que el usuario y contraseña ingresados sean erróneos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (txtUsuario.Text == Usuario && txtContraseña.Text == Contraseña && respuesta == "Se ha iniciado sesión correctamente")
                {
                    MessageBox.Show(b_OperacionesGestionLogin.Entrar(idLogin, Usuario, Contraseña));

                    //MessageBox.Show(respuesta);

                    this.Hide();

                    frmInicio formIni = new frmInicio();

                    formIni.Show();
                }
                else
                {
                    MessageBox.Show("Datos incorrectos, puede que el usuario y contraseña ingresados sean erróneos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void llOlvidarContra_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("El usuario y contraseña es 'admin'", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            ConexionSQL conectar = new ConexionSQL();
            conectar.abrir();
        }

        public void Conversiones()
        {
            idLogin = Convert.ToInt32(lblIdLogin.Text);
            Usuario = txtUsuario.Text;
            Contraseña = txtContraseña.Text;

        }
    }
}