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
using Business;

namespace Refaccionaria_Terry
{
    public partial class frmClientes : Form
    {
        private B_OperacionesGestionClientes b_OperacionesGestionClientes = new B_OperacionesGestionClientes();

        String nomCliente, apPaterno, apMaterno, telCliente;
        int idCliente, Descuentos, compraTotal;

        public frmClientes()
        {
            InitializeComponent();
        }

        private void txtNomClientes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 47) || ((e.KeyChar >= 48 && e.KeyChar <= 64 || e.KeyChar >= 91 && e.KeyChar <= 96 || e.KeyChar >= 123 && e.KeyChar <= 126)))
            {
                MessageBox.Show("El nombre o los nombres deben contener letra", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtPriApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 47) || ((e.KeyChar >= 48 && e.KeyChar <= 64 || e.KeyChar >= 91 && e.KeyChar <= 96 || e.KeyChar >= 123 && e.KeyChar <= 126)))
            {
                MessageBox.Show("Solo El primer apellido debe contener letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtSegApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 47) || ((e.KeyChar >= 48 && e.KeyChar <= 64 || e.KeyChar >= 91 && e.KeyChar <= 96 || e.KeyChar >= 123 && e.KeyChar <= 126)))
            {
                MessageBox.Show("El segundo apellido debe contener letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtTelClientes_Validated(object sender, EventArgs e)
        {
            this.errorProvider1.SetError(txtTelClientes, Regex.IsMatch(txtTelClientes.Text, "^[0-9]*$") ? "" : "Solo números y números positivos");
        }

        private void txtDescuentos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 35) || ((e.KeyChar >= 38 && e.KeyChar <= 47)))
            {
                MessageBox.Show("El valor debe contener números y caracteres válidos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtComTotales_Validated(object sender, EventArgs e)
        {
            this.errorProvider2.SetError(txtComTotales, Regex.IsMatch(txtComTotales.Text, "^[0-9]*$") ? "" : "Solo números y números positivos");
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            cargarDatosInicialesClientes();
        }

        private void btnRegClientes_Click(object sender, EventArgs e)
        {
            Conversiones();

            MessageBox.Show(b_OperacionesGestionClientes.insertarClientes(idCliente, nomCliente, apPaterno, apMaterno, telCliente, Descuentos, compraTotal));

            txtNomClientes.Text = "";
            txtPriApellido.Text = "";
            txtSegApellido.Text = "";
            txtTelClientes.Text = "";
            txtDescuentos.Text = "";
            txtComTotales.Text = "";

            dgvClientes.DataSource = b_OperacionesGestionClientes.cargarClientes();
        }

        private void txtBusNomCli_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 47) || ((e.KeyChar >= 48 && e.KeyChar <= 64 || e.KeyChar >= 91 && e.KeyChar <= 96 || e.KeyChar >= 123 && e.KeyChar <= 126)))
            {
                MessageBox.Show("El nombre o los nombres deben contener letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtBusClientes_TextChanged(object sender, EventArgs e)
        {
            nomCliente = txtBusClientes.Text;
            if (nomCliente != "")
                dgvClientes.DataSource = b_OperacionesGestionClientes.busquedaClientes(nomCliente);
            else
                dgvClientes.DataSource = b_OperacionesGestionClientes.cargarClientes();
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lblidCliente.Text = dgvClientes.CurrentRow.Cells[0].Value.ToString();
            txtNomClientes.Text = dgvClientes.CurrentRow.Cells[1].Value.ToString();
            txtPriApellido.Text = dgvClientes.CurrentRow.Cells[2].Value.ToString();
            txtSegApellido.Text = dgvClientes.CurrentRow.Cells[3].Value.ToString();
            txtTelClientes.Text = dgvClientes.CurrentRow.Cells[4].Value.ToString();
            txtDescuentos.Text = dgvClientes.CurrentRow.Cells[5].Value.ToString();
            txtComTotales.Text = dgvClientes.CurrentRow.Cells[6].Value.ToString();
        }

        private void btnBusClientes_Click(object sender, EventArgs e)
        {
            nomCliente = txtBusClientes.Text;
            if (nomCliente != "")
                dgvClientes.DataSource = b_OperacionesGestionClientes.busquedaClientes(nomCliente);
            else
                dgvClientes.DataSource = b_OperacionesGestionClientes.cargarClientes();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Conversiones();

            MessageBox.Show(b_OperacionesGestionClientes.actualizarClientes(idCliente, nomCliente, apPaterno, apMaterno, telCliente, Descuentos, compraTotal));

            txtNomClientes.Text = "";
            txtPriApellido.Text = "";
            txtSegApellido.Text = "";
            txtTelClientes.Text = "";
            txtDescuentos.Text = "";
            txtComTotales.Text = "";

            dgvClientes.DataSource = b_OperacionesGestionClientes.cargarClientes();
        }

        private void txtBusApCli1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 47) || ((e.KeyChar >= 48 && e.KeyChar <= 64 || e.KeyChar >= 91 && e.KeyChar <= 96 || e.KeyChar >= 123 && e.KeyChar <= 126)))
            {
                MessageBox.Show("El primer apellido debe contener letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            dgvClientes.Rows.Remove(dgvClientes.CurrentRow);
            Conversiones();

            MessageBox.Show(b_OperacionesGestionClientes.EliminarClientes(idCliente, nomCliente, apPaterno, apMaterno, telCliente, Descuentos, compraTotal));

            dgvClientes.DataSource = b_OperacionesGestionClientes.cargarClientes();
        }

        private void txtBusApCli2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 47) || ((e.KeyChar >= 48 && e.KeyChar <= 64 || e.KeyChar >= 91 && e.KeyChar <= 96 || e.KeyChar >= 123 && e.KeyChar <= 126)))
            {
                MessageBox.Show("El segundo apellido debe contener letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }

        }

        private void txtBusDescuentos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 35) || ((e.KeyChar >= 38 && e.KeyChar <= 41)))
            {
                MessageBox.Show("El valor debe contener números y caracteres válidos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtBusClientes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 35) || ((e.KeyChar >= 38 && e.KeyChar <= 41)))
            {
                MessageBox.Show("El campo solo permite letras, números y caracteres válidos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        public void Conversiones()
        {
            idCliente = Convert.ToInt32(lblidCliente.Text);
            nomCliente = txtNomClientes.Text.ToUpper();
            apPaterno = txtPriApellido.Text.ToUpper();
            apMaterno = txtSegApellido.Text.ToUpper();
            telCliente = txtTelClientes.Text.ToUpper();
            Descuentos = Convert.ToInt32(txtDescuentos.Text);
            compraTotal = Convert.ToInt32(txtComTotales.Text);

        }

        public void cargarDatosInicialesClientes()
        {
            //Cargar datos en el datagridview
            dgvClientes.DataSource = b_OperacionesGestionClientes.cargarClientes();

            //Ocultar la columna de Id del datagridview
            dgvClientes.Columns["idCliente"].Visible = false;
        }
    }
}
