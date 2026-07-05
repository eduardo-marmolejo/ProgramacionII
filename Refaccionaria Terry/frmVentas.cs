using Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Refaccionaria_Terry
{
    public partial class frmVentas : Form
    {
        private B_OperacionesGestionVentas b_OperacionesGestionVentas = new B_OperacionesGestionVentas();

        int idVenta, PrecioVen, numProVen, precioTotal, pagaCon, Cambio, idProducto, idCliente;
        String Nombre;
        DateTime Fecha;

        private void frmVentas_Load(object sender, EventArgs e)
        {
            cargarDatosInicialesVentas();
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            Conversiones();

            MessageBox.Show(b_OperacionesGestionVentas.insertarVentas(idVenta, Nombre, PrecioVen, numProVen, Fecha, precioTotal, pagaCon, Cambio, idProducto, idCliente));

            dgvVentas.DataSource = b_OperacionesGestionVentas.cargarventas();
        }

        private void txtBuscarVenta_TextChanged(object sender, EventArgs e)
        {
            Nombre = txtBuscarVenta.Text;
            if (Nombre != "")
                dgvVentas.DataSource = b_OperacionesGestionVentas.busquedaVentas(Nombre);
            else
                dgvVentas.DataSource = b_OperacionesGestionVentas.cargarventas();
        }

        private void dgvVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lblIdVenta.Text = dgvVentas.CurrentRow.Cells[0].Value.ToString();
            txtNomVentas.Text = dgvVentas.CurrentRow.Cells[1].Value.ToString();
            txtPreVentas.Text = dgvVentas.CurrentRow.Cells[2].Value.ToString();
            txtNProVentas.Text = dgvVentas.CurrentRow.Cells[3].Value.ToString();
            dtpFecha.Text = dgvVentas.CurrentRow.Cells[4].Value.ToString();
            txtTotal.Text = dgvVentas.CurrentRow.Cells[5].Value.ToString();
            txtPagaCon.Text = dgvVentas.CurrentRow.Cells[6].Value.ToString();
            txtCambio.Text = dgvVentas.CurrentRow.Cells[7].Value.ToString();
            txtidProducto.Text = dgvVentas.CurrentRow.Cells[8].Value.ToString();
            txtidCliente.Text = dgvVentas.CurrentRow.Cells[9].Value.ToString();

        }

        private void btnBuscarVenta_Click(object sender, EventArgs e)
        {
            Nombre = txtBuscarVenta.Text;
            if (Nombre != "")
                dgvVentas.DataSource = b_OperacionesGestionVentas.busquedaVentas(Nombre);
            else
                dgvVentas.DataSource = b_OperacionesGestionVentas.cargarventas();
        }

        public frmVentas()
        {
            InitializeComponent();
        }

        private void txtCambio_Validated(object sender, EventArgs e)
        {
            this.errorProvider3.SetError(txtCambio, Regex.IsMatch(txtCambio.Text, "^[0-9]*$") ? "" : "El campo solo números y números positivos");
        }

        private void txtidProducto_Validated(object sender, EventArgs e)
        {
            this.errorProvider3.SetError(txtidProducto, Regex.IsMatch(txtidProducto.Text, "^[0-9]*$") ? "" : "El campo solo números y números positivos");
        }

        private void txtidCliente_Validated(object sender, EventArgs e)
        {
            this.errorProvider3.SetError(txtidCliente, Regex.IsMatch(txtidCliente.Text, "^[0-9]*$") ? "" : "El campo solo números y números positivos");
        }

        private void btnCalcularCambio_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txtTotal.Text);
            int b = Convert.ToInt32(txtPagaCon.Text);

            if (b >= a)
            {
                int c = b - a;
                txtCambio.Text = c.ToString();
            }
            else
                if (b < a)
            {
                MessageBox.Show("El pago no cubre el total");
            }
        }

        private void btnCalcularTotal_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txtPreVentas.Text);
            int y = Convert.ToInt32(txtNProVentas.Text);

            int a = x * y;

            txtTotal.Text = a.ToString();
        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNomVentas.Text = "";
            txtPreVentas.Text = "";
            txtNProVentas.Text = "";
            txtTotal.Text = "";
            txtPagaCon.Text = "";
            txtCambio.Text = "";
            txtidProducto.Text = "";
            txtidCliente.Text = "";

        }

        private void txtNomVentas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 47) || ((e.KeyChar >= 48 && e.KeyChar <= 64 || e.KeyChar >= 91 && e.KeyChar <= 96 || e.KeyChar >= 123 && e.KeyChar <= 126)))
            {
                MessageBox.Show("El campo solo permite letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtPreVentas_Validated(object sender, EventArgs e)
        {
            this.errorProvider1.SetError(txtPreVentas, Regex.IsMatch(txtPreVentas.Text, "^[0-9]*$") ? "" : "El campo solo números y números positivos");
        }

        private void txtNProVentas_Validated(object sender, EventArgs e)
        {
            this.errorProvider2.SetError(txtNProVentas, Regex.IsMatch(txtNProVentas.Text, "^[0-9]*$") ? "" : "El campo solo números y números positivos");
        }

        private void txtPagaCon_Validated(object sender, EventArgs e)
        {
            this.errorProvider3.SetError(txtPagaCon, Regex.IsMatch(txtPagaCon.Text, "^[0-9]*$") ? "" : "El campo solo números y números positivos");
        }

        public void Conversiones()
        {

            idVenta = Convert.ToInt32(lblIdVenta.Text);
            Nombre = txtNomVentas.Text.ToUpper();
            PrecioVen = Convert.ToInt32(txtPreVentas.Text);
            numProVen = Convert.ToInt32(txtNProVentas.Text);
            Fecha = dtpFecha.Value.Date;
            //Fecha = DateTime.Now.Date;
            //string Fecha1= Fecha.ToShortDateString();
            //MessageBox.Show(Fecha.ToShortDateString());
            
            // Fecha = Convert.ToDateTime(dtpFecha.Value.ToShortDateString());
            // Fecha=Convert.ToString(dtpFecha.Text);
            //fecha = Fecha;
            //Fecha = Convert.ToInt32(dtpFecha.Value.Dat);
            //string Fecha = string.Format(dtpFecha.Format, "yyyy-MM-dd");
            //Fecha = DateTimePickerFormat.Short(dtpFecha.Format.ToString());
            //Fecha = dtpFecha.Format(DateTimePickerFormat.Short(dtpFecha.Format,"yy-MM-dd"));
            precioTotal = Convert.ToInt32(txtTotal.Text);
            pagaCon = Convert.ToInt32(txtPagaCon.Text);
            Cambio = Convert.ToInt32(txtCambio.Text);
            idProducto = Convert.ToInt32(txtidProducto.Text);
            idCliente = Convert.ToInt32(txtidCliente.Text);

        }

        public void cargarDatosInicialesVentas()
        {
            //Cargar datos en el datagridview
            dgvVentas.DataSource = b_OperacionesGestionVentas.cargarventas();

            //Ocultar la columna de Id del datagridview
            dgvVentas.Columns["idVenta"].Visible = false;
        }
    }
}
