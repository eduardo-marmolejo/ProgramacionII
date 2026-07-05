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
    public partial class frmCompras : Form
    {
        private B_OperacionesGestionCompras b_OperacionesGestionCompras = new B_OperacionesGestionCompras();

        int idCompras, precioCom, numProCom, totalCompra, idProducto, idProveedor;
        String nomCompra;
        DateTime fechaCompra;

        public frmCompras()
        {
            InitializeComponent();
        }

        private void txtNomCompras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 47) || ((e.KeyChar >= 48 && e.KeyChar <= 64 || e.KeyChar >= 91 && e.KeyChar <= 96 || e.KeyChar >= 123 && e.KeyChar <= 126)))
            {
                MessageBox.Show("El nombre solo permite letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            Conversiones();

            MessageBox.Show(b_OperacionesGestionCompras.insertarCompras(idCompras, nomCompra,precioCom,numProCom,fechaCompra,totalCompra, idProducto, idProveedor));

            dgvCompras.DataSource = b_OperacionesGestionCompras.cargarCompras();
        }

        private void dgvCompras_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lblidCompra.Text = dgvCompras.CurrentRow.Cells[0].Value.ToString();
            txtNomCompras.Text = dgvCompras.CurrentRow.Cells[1].Value.ToString();
            txtPrecioCom.Text = dgvCompras.CurrentRow.Cells[2].Value.ToString();
            txtNumProductos.Text = dgvCompras.CurrentRow.Cells[3].Value.ToString();
            dtpFecha.Text = dgvCompras.CurrentRow.Cells[4].Value.ToString();
            lblTotal.Text = dgvCompras.CurrentRow.Cells[5].Value.ToString();
            txtidProducto.Text = dgvCompras.CurrentRow.Cells[6].Value.ToString();
            txtidProveedor.Text = dgvCompras.CurrentRow.Cells[7].Value.ToString();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txtPrecioCom.Text);
            int y = Convert.ToInt32(txtNumProductos.Text);

            int a = x * y;

            lblTotal.Text = a.ToString();
        }

        private void txtPrecioCom_Validated(object sender, EventArgs e)
        {
            this.errorProvider1.SetError(txtPrecioCom, Regex.IsMatch(txtPrecioCom.Text, "^[0-9]*$") ? "" : "Solo números y números positivos");
        }

        private void txtNumProductos_Validated(object sender, EventArgs e)
        {
            this.errorProvider2.SetError(txtNumProductos, Regex.IsMatch(txtNumProductos.Text, "^[0-9]*$") ? "" : "Solo números y números positivos");
        }

        private void txtidProducto_Validated(object sender, EventArgs e)
        {
            this.errorProvider2.SetError(txtidProducto, Regex.IsMatch(txtidProducto.Text, "^[0-9]*$") ? "" : "Solo números y números positivos");
        }

        private void txtidProveedor_Validated(object sender, EventArgs e)
        {
            this.errorProvider2.SetError(txtidProveedor, Regex.IsMatch(txtidProveedor.Text, "^[0-9]*$") ? "" : "Solo números y números positivos");
        }

        private void frmCompras_Load(object sender, EventArgs e)
        {
            cargarDatosInicialesCompras();
        }

        public void Conversiones()
        {
            idCompras = Convert.ToInt32(lblidCompra.Text);
            nomCompra = txtNomCompras.Text.ToUpper();
            precioCom = Convert.ToInt32(txtPrecioCom.Text);
            numProCom = Convert.ToInt32(txtNumProductos.Text);
            fechaCompra = dtpFecha.Value.Date;
            totalCompra = Convert.ToInt32(lblTotal.Text);
            idProducto = Convert.ToInt32(txtidProducto.Text);
            idProveedor = Convert.ToInt32(txtidProveedor.Text);

        }

        public void cargarDatosInicialesCompras()
        {
            //Cargar datos en el datagridview
            dgvCompras.DataSource = b_OperacionesGestionCompras.cargarCompras();

            //Ocultar la columna de Id del datagridview
            dgvCompras.Columns["idCompras"].Visible = false;
        }
    }
}
