using Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Refaccionaria_Terry
{
    public partial class frmReporPagos : Form
    {
        private B_OperacionesGestionCompras b_OperacionesGestionCompras = new B_OperacionesGestionCompras();

        public frmReporPagos()
        {
            InitializeComponent();
        }

        private void frmReporPagos_Load(object sender, EventArgs e)
        {
            dgvReporPagos.DataSource = b_OperacionesGestionCompras.cargarCompras();
        }
    }
}
