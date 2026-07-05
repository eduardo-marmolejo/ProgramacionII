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
    public partial class frmEmpleados : Form
    {
        private B_OperacionesGestiónEmpleados b_OperacionesGestionEmpleados = new B_OperacionesGestiónEmpleados();

        String nomEmpleado, apPaterno, apMaterno, CURP, telEmpleado;
        int idEmpleado, idLogin, idDireccion;


        public frmEmpleados()
        {
            InitializeComponent();
        }

        private void txtidLogin_Validated(object sender, EventArgs e)
        {
            this.errorProvider1.SetError(txtidLogin, Regex.IsMatch(txtidLogin.Text, "^[0-9]*$") ? "" : "El campo solo números y números positivos");
        }

        private void txtidDireccion_Validated(object sender, EventArgs e)
        {
            this.errorProvider2.SetError(txtidDireccion, Regex.IsMatch(txtidDireccion.Text, "^[0-9]*$") ? "" : "El campo solo números y números positivos");
        }

        private void frmEmpleados_Load(object sender, EventArgs e)
        {
            cargarDatosInicialesEmpleados();
        }

        private void btnRegEmpleado_Click(object sender, EventArgs e)
        {
            Conversiones();

            MessageBox.Show(b_OperacionesGestionEmpleados.insertarEmpleados(idEmpleado, nomEmpleado, apPaterno, apMaterno, CURP, telEmpleado, idLogin, idDireccion));

            txtNomEmpleado.Text = "";
            txtPriApEmpleado.Text = "";
            txtSegApEmpleado.Text = "";
            txtCurp.Text = "";
            txtTelEmpleado.Text = "";
            txtidLogin.Text = "";
            txtidDireccion.Text = "";

            dgvEmpleado.DataSource = b_OperacionesGestionEmpleados.cargarEmpleados();
        }

        private void txtNomEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 47) || ((e.KeyChar >= 48 && e.KeyChar <= 64 || e.KeyChar>=91 && e.KeyChar<=96 || e.KeyChar>=123 && e.KeyChar<=126)))
            {
                MessageBox.Show("El nombre o los nombres deben contener letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtBusEmpleado_TextChanged(object sender, EventArgs e)
        {
            nomEmpleado = txtBusEmpleado.Text;
            if (nomEmpleado != "")
                dgvEmpleado.DataSource = b_OperacionesGestionEmpleados.busquedaEmpleados(nomEmpleado);
            else
                dgvEmpleado.DataSource = b_OperacionesGestionEmpleados.cargarEmpleados();
        }

        private void dgvEmpleado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lblidEmpleado.Text = dgvEmpleado.CurrentRow.Cells[0].Value.ToString();
            txtNomEmpleado.Text = dgvEmpleado.CurrentRow.Cells[1].Value.ToString();
            txtPriApEmpleado.Text = dgvEmpleado.CurrentRow.Cells[2].Value.ToString();
            txtSegApEmpleado.Text = dgvEmpleado.CurrentRow.Cells[3].Value.ToString();
            txtCurp.Text = dgvEmpleado.CurrentRow.Cells[4].Value.ToString();
            txtTelEmpleado.Text = dgvEmpleado.CurrentRow.Cells[5].Value.ToString();
            txtidLogin.Text = dgvEmpleado.CurrentRow.Cells[6].Value.ToString();
            txtidDireccion.Text = dgvEmpleado.CurrentRow.Cells[7].Value.ToString();
        }

        private void btnBusEmpleado_Click(object sender, EventArgs e)
        {
            nomEmpleado = txtBusEmpleado.Text;
            if (nomEmpleado != "")
                dgvEmpleado.DataSource = b_OperacionesGestionEmpleados.busquedaEmpleados(nomEmpleado);
            else
                dgvEmpleado.DataSource = b_OperacionesGestionEmpleados.cargarEmpleados();
        }

        private void btnActualizarEmpleado_Click(object sender, EventArgs e)
        {
            Conversiones();

            MessageBox.Show(b_OperacionesGestionEmpleados.actualizarEmpleados(idEmpleado, nomEmpleado, apPaterno, apMaterno, CURP, telEmpleado, idLogin, idDireccion));

            dgvEmpleado.DataSource = b_OperacionesGestionEmpleados.cargarEmpleados();

            txtNomEmpleado.Text = "";
            txtPriApEmpleado.Text = "";
            txtSegApEmpleado.Text = "";
            txtCurp.Text = "";
            txtTelEmpleado.Text = "";
            txtidLogin.Text = "";
            txtidDireccion.Text = "";
        }

        private void txtPriApEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 47) || ((e.KeyChar >= 48 && e.KeyChar <= 64 || e.KeyChar >= 91 && e.KeyChar <= 96 || e.KeyChar >= 123 && e.KeyChar <= 126)))
            {
                MessageBox.Show("Solo El primer apellido debe contener letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void btnEliminarEmpleado_Click(object sender, EventArgs e)
        {
            dgvEmpleado.Rows.Remove(dgvEmpleado.CurrentRow);
            Conversiones();

            MessageBox.Show(b_OperacionesGestionEmpleados.EliminarEmpleados(idEmpleado, nomEmpleado, apPaterno, apMaterno, CURP, telEmpleado, idLogin, idDireccion));

            dgvEmpleado.DataSource = b_OperacionesGestionEmpleados.cargarEmpleados();
        }

        private void txtSegApEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 47) || ((e.KeyChar >= 48 && e.KeyChar <= 64 || e.KeyChar >= 91 && e.KeyChar <= 96 || e.KeyChar >= 123 && e.KeyChar <= 126)))
            {
                MessageBox.Show("El segundo apellido debe contener letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtCurp_KeyPress(object sender, KeyPressEventArgs e)
        {
            Regex reCurp = new Regex("^.*(?=.{18})(?=.*[0-9])(?=.*[A-ZÑ]).*$", RegexOptions.Compiled);
            if (!reCurp.IsMatch(txtCurp.Text))
            {
                errorProvider1.SetError(txtCurp, "Debe colocar una curp  válida");
                txtCurp.Focus();
                return;
            }
            errorProvider1.SetError(txtCurp, "");
        }

        private void txtTelEmpleado_Validated(object sender, EventArgs e)
        {
            //this.errorProvider1.SetError(txtTelEmpleado, Regex.IsMatch(txtTelEmpleado.Text, "^[0-9]*$") ? "" : "Solo números y números positivos");
            Regex reTelefono = new Regex("[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]", RegexOptions.Compiled);
            if (!reTelefono.IsMatch(txtTelEmpleado.Text))
            {
                errorProvider1.SetError(txtTelEmpleado, "Debe colocar un teléfono válido");
                txtTelEmpleado.Focus();
                return;
            }
            errorProvider1.SetError(txtTelEmpleado, "");
        }

        private void txtBusEmpleado_KeyPress(object sender, KeyPressEventArgs e)
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
            idEmpleado = Convert.ToInt32(lblidEmpleado.Text);
            nomEmpleado = txtNomEmpleado.Text.ToUpper();
            apPaterno = txtPriApEmpleado.Text.ToUpper();
            apMaterno = txtSegApEmpleado.Text.ToUpper();
            CURP = txtCurp.Text.ToUpper();
            telEmpleado = txtTelEmpleado.Text.ToUpper();
            idLogin = Convert.ToInt32(txtidLogin.Text);
            idDireccion = Convert.ToInt32(txtidDireccion.Text);

        }

        public void cargarDatosInicialesEmpleados()
        {
            //Cargar datos en el datagridview
            dgvEmpleado.DataSource = b_OperacionesGestionEmpleados.cargarEmpleados();

            //Ocultar la columna de Id del datagridview
            dgvEmpleado.Columns["idEmpleado"].Visible = false;
        }
    }
}
