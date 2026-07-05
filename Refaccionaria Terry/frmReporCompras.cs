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
    public partial class frmReporCompras : Form
    {
        private B_OperacionesGestionCompras b_OperacionesGestionCompras = new B_OperacionesGestionCompras();

        public frmReporCompras()
        {
            InitializeComponent();
        }

        private void frmReporCompras_Load(object sender, EventArgs e)
        {
            dgvReporCompras.DataSource = b_OperacionesGestionCompras.cargarCompras();
        }
    }
}
