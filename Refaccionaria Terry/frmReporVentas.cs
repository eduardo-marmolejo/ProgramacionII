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
    public partial class frmReporVentas : Form
    {
        private B_OperacionesGestionVentas b_OperacionesGestionVentas = new B_OperacionesGestionVentas();

        public frmReporVentas()
        {
            InitializeComponent();
        }

        private void frmReporVentas_Load(object sender, EventArgs e)
        {
            dgvReporVentas.DataSource = b_OperacionesGestionVentas.cargarventas();
        }
    }
}
