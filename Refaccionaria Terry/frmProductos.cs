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
    public partial class frmProductos : Form
    {
        private B_OperacionesGestionProductos b_OperacionesGestionProductos = new B_OperacionesGestionProductos();

        String Nombre;
        int idProducto,Precio, Stock;

        public frmProductos()
        {
            InitializeComponent();
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            cargarDatosIniciales();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Conversiones();

            MessageBox.Show(b_OperacionesGestionProductos.insertarProductos(idProducto, Nombre, Precio, Stock));

            txtNomProductos.Text = "";
            txtPreProductos.Text = "";
            txtStock.Text = "";

            dgvProductos.DataSource= b_OperacionesGestionProductos.cargarProductos();
        }

        public void Conversiones()
        {
            idProducto = Convert.ToInt32(lblidProductos.Text);
            Nombre = txtNomProductos.Text.ToUpper();
            Precio = Convert.ToInt32(txtPreProductos.Text);
            Stock = Convert.ToInt32(txtStock.Text);

        }

       private void btnEliminar_Click(object sender, EventArgs e)
        {
            dgvProductos.Rows.Remove(dgvProductos.CurrentRow);
            Conversiones();

            MessageBox.Show(b_OperacionesGestionProductos.EliminarProductos(idProducto, Nombre, Precio, Stock));

            dgvProductos.DataSource = b_OperacionesGestionProductos.cargarProductos();
        }

        private void txtNomProductos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 47) || ((e.KeyChar >= 48 && e.KeyChar <= 64 || e.KeyChar >= 91 && e.KeyChar <= 96 || e.KeyChar >= 123 && e.KeyChar <= 126)))
            {
                MessageBox.Show("El campo solo permite letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtPreProductos_Validated(object sender, EventArgs e)
        {
            this.errorProvider2.SetError(txtPreProductos, Regex.IsMatch(txtPreProductos.Text, "^[0-9]*$") ? "" : "El campo solo números y números positivos");
        }

        private void txtStock_Validated(object sender, EventArgs e)
        {
            this.errorProvider3.SetError(txtStock, Regex.IsMatch(txtStock.Text, "^[0-9]*$") ? "" : "El campo solo números y números positivos");
        }

        private void txtBusNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 47) || ((e.KeyChar >= 48 && e.KeyChar <= 64 || e.KeyChar >= 91 && e.KeyChar <= 96 || e.KeyChar >= 123 && e.KeyChar <= 126)))
            {
                MessageBox.Show("El campo solo permite letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Nombre = txtBuscar.Text;
            if (Nombre != "")
                dgvProductos.DataSource = b_OperacionesGestionProductos.busquedaProductos(Nombre);
            else
                dgvProductos.DataSource = b_OperacionesGestionProductos.cargarProductos();
        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lblidProductos.Text = dgvProductos.CurrentRow.Cells[0].Value.ToString();
            txtNomProductos.Text = dgvProductos.CurrentRow.Cells[1].Value.ToString();
            txtPreProductos.Text = dgvProductos.CurrentRow.Cells[2].Value.ToString();
            txtStock.Text = dgvProductos.CurrentRow.Cells[3].Value.ToString();
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 35) || ((e.KeyChar >= 38 && e.KeyChar <= 41)))
            {
                MessageBox.Show("El campo solo permite letras, números y caracteres válidos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Nombre = txtBuscar.Text;
            if (Nombre != "")
                dgvProductos.DataSource = b_OperacionesGestionProductos.busquedaProductos(Nombre);
            else
                dgvProductos.DataSource = b_OperacionesGestionProductos.cargarProductos();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Conversiones();

            MessageBox.Show(b_OperacionesGestionProductos.actualizarProducto(idProducto, Nombre, Precio, Stock));

            dgvProductos.DataSource = b_OperacionesGestionProductos.cargarProductos();

            txtNomProductos.Text = "";
            txtPreProductos.Text = "";
            txtStock.Text = "";
        }

        public void cargarDatosIniciales()
        {
            //Cargar datos en el datagridview
            dgvProductos.DataSource = b_OperacionesGestionProductos.cargarProductos();

            //Ocultar la columna de Id del datagridview
            dgvProductos.Columns["idProducto"].Visible = false;
        }
    }
}
