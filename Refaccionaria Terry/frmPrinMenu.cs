using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Business;

namespace Refaccionaria_Terry
{
    public partial class frmInicio : Form
    {
        private B_OperacionesGestionVentas b_OperacionesGestionVentas = new B_OperacionesGestionVentas();

        public frmInicio()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void pbCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            pbMaximizar.Visible = false;
            pbRestaurar.Visible = true;
        }

        private void pbRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            pbRestaurar.Visible = false;
            pbMaximizar.Visible = true;
        }

        private void pbMinizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void pnlBarraTítulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            pnlSubMenuReportes.Visible = true;
        }

        private void btnReporVentas_Click(object sender, EventArgs e)
        {
            pnlSubMenuReportes.Visible = false;
            //AbrirFormHija(new frmReporVentas());
            AbrirFormHija(new CR_ReportesVentas.CR_RV());

        }

        private void btnReporCompras_Click(object sender, EventArgs e)
        {
            pnlSubMenuReportes.Visible = false;
            //AbrirFormHija(new frmReporCompras());
            AbrirFormHija(new CR_ReportesCompras.CR_CC());
        }

        private void btnReporPagos_Click(object sender, EventArgs e)
        {
            pnlSubMenuReportes.Visible = false;
            //AbrirFormHija(new frmReporPagos());
            AbrirFormHija(new CR_ReporesPagos.CR_RP());
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pbSalir_Click(object sender, EventArgs e)
        {
            this.Close();

            frmLogin frm = new frmLogin();

            frm.Show();
        }

        private void AbrirFormHija(object formhija)
        {
            if (this.pnlContenedor.Controls.Count > 0)
            this.pnlContenedor.Controls.RemoveAt(0);
            Form formhi = formhija as Form;
            formhi.TopLevel = false;
            formhi.Dock = DockStyle.Fill;
            this.pnlContenedor.Controls.Add(formhi);
            this.pnlContenedor.Tag = formhi;
            formhi.Show();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new frmProductos());
        }

        private void pbIniPrincipal_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new frmIniPrincipal());
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new frmVentas());
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new frmClientes());
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new frmCompras());
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new frmEmpleados());
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {
            this.MaximumSize = SystemInformation.PrimaryMonitorMaximizedWindowSize;
        }
    }
}
