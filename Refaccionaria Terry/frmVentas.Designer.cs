
namespace Refaccionaria_Terry
{
    partial class frmVentas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVentas));
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnVender = new System.Windows.Forms.Button();
            this.txtNomVentas = new System.Windows.Forms.TextBox();
            this.txtNProVentas = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPreVentas = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPagaCon = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCambio = new System.Windows.Forms.TextBox();
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblIdVenta = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtidProducto = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtidCliente = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBuscarVenta = new System.Windows.Forms.TextBox();
            this.btnBuscarVenta = new System.Windows.Forms.Button();
            this.btnCalcularCambio = new System.Windows.Forms.Button();
            this.btnCalcularTotal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpFecha
            // 
            this.dtpFecha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(282, 225);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(102, 23);
            this.dtpFecha.TabIndex = 6;
            this.dtpFecha.ValueChanged += new System.EventHandler(this.dtpFecha_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(212, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 19);
            this.label6.TabIndex = 31;
            this.label6.Text = "FECHA:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(569, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 19);
            this.label5.TabIndex = 30;
            this.label5.Text = "TOTAL:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(450, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 40);
            this.label1.TabIndex = 22;
            this.label1.Text = "VENTAS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(212, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 19);
            this.label2.TabIndex = 23;
            this.label2.Text = "NOMBRE:";
            // 
            // btnVender
            // 
            this.btnVender.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVender.Location = new System.Drawing.Point(551, 257);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(106, 34);
            this.btnVender.TabIndex = 13;
            this.btnVender.Text = "VENDER";
            this.btnVender.UseVisualStyleBackColor = true;
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
            // 
            // txtNomVentas
            // 
            this.txtNomVentas.Location = new System.Drawing.Point(297, 113);
            this.txtNomVentas.Name = "txtNomVentas";
            this.txtNomVentas.Size = new System.Drawing.Size(225, 23);
            this.txtNomVentas.TabIndex = 3;
            this.txtNomVentas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomVentas_KeyPress);
            // 
            // txtNProVentas
            // 
            this.txtNProVentas.Location = new System.Drawing.Point(367, 187);
            this.txtNProVentas.Name = "txtNProVentas";
            this.txtNProVentas.Size = new System.Drawing.Size(155, 23);
            this.txtNProVentas.TabIndex = 5;
            this.txtNProVentas.Validated += new System.EventHandler(this.txtNProVentas_Validated);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(212, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 19);
            this.label3.TabIndex = 25;
            this.label3.Text = "PRECIO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(212, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 19);
            this.label4.TabIndex = 27;
            this.label4.Text = "NUM. PRODUCTOS:";
            // 
            // txtPreVentas
            // 
            this.txtPreVentas.Location = new System.Drawing.Point(297, 149);
            this.txtPreVentas.Name = "txtPreVentas";
            this.txtPreVentas.Size = new System.Drawing.Size(225, 23);
            this.txtPreVentas.TabIndex = 4;
            this.txtPreVentas.Validated += new System.EventHandler(this.txtPreVentas_Validated);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.Location = new System.Drawing.Point(712, 257);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(106, 34);
            this.btnLimpiar.TabIndex = 14;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // dgvVentas
            // 
            this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentas.Location = new System.Drawing.Point(169, 297);
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.RowTemplate.Height = 25;
            this.dgvVentas.Size = new System.Drawing.Size(744, 264);
            this.dgvVentas.TabIndex = 33;
            this.dgvVentas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVentas_CellContentClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(528, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 19);
            this.label7.TabIndex = 35;
            this.label7.Text = "PAGA CON:";
            // 
            // txtPagaCon
            // 
            this.txtPagaCon.Location = new System.Drawing.Point(634, 148);
            this.txtPagaCon.Name = "txtPagaCon";
            this.txtPagaCon.Size = new System.Drawing.Size(225, 23);
            this.txtPagaCon.TabIndex = 8;
            this.txtPagaCon.Validated += new System.EventHandler(this.txtPagaCon_Validated);
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(634, 113);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(225, 23);
            this.txtTotal.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(551, 186);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 19);
            this.label10.TabIndex = 40;
            this.label10.Text = "CAMBIO:";
            // 
            // txtCambio
            // 
            this.txtCambio.Enabled = false;
            this.txtCambio.Location = new System.Drawing.Point(634, 187);
            this.txtCambio.Name = "txtCambio";
            this.txtCambio.Size = new System.Drawing.Size(225, 23);
            this.txtCambio.TabIndex = 9;
            this.txtCambio.Validated += new System.EventHandler(this.txtCambio_Validated);
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // lblIdVenta
            // 
            this.lblIdVenta.AutoSize = true;
            this.lblIdVenta.Location = new System.Drawing.Point(155, 33);
            this.lblIdVenta.Name = "lblIdVenta";
            this.lblIdVenta.Size = new System.Drawing.Size(13, 15);
            this.lblIdVenta.TabIndex = 41;
            this.lblIdVenta.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(405, 227);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 19);
            this.label8.TabIndex = 43;
            this.label8.Text = "PRODUCTO:";
            // 
            // txtidProducto
            // 
            this.txtidProducto.Location = new System.Drawing.Point(508, 228);
            this.txtidProducto.Name = "txtidProducto";
            this.txtidProducto.Size = new System.Drawing.Size(103, 23);
            this.txtidProducto.TabIndex = 10;
            this.txtidProducto.Validated += new System.EventHandler(this.txtidProducto_Validated);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(627, 227);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 19);
            this.label9.TabIndex = 45;
            this.label9.Text = "CLIENTE:";
            // 
            // txtidCliente
            // 
            this.txtidCliente.Location = new System.Drawing.Point(704, 228);
            this.txtidCliente.Name = "txtidCliente";
            this.txtidCliente.Size = new System.Drawing.Size(103, 23);
            this.txtidCliente.TabIndex = 11;
            this.txtidCliente.Validated += new System.EventHandler(this.txtidCliente_Validated);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(212, 69);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(127, 19);
            this.label11.TabIndex = 46;
            this.label11.Text = "BUSCAR VENTA:";
            // 
            // txtBuscarVenta
            // 
            this.txtBuscarVenta.Location = new System.Drawing.Point(345, 65);
            this.txtBuscarVenta.Name = "txtBuscarVenta";
            this.txtBuscarVenta.Size = new System.Drawing.Size(225, 23);
            this.txtBuscarVenta.TabIndex = 1;
            this.txtBuscarVenta.TextChanged += new System.EventHandler(this.txtBuscarVenta_TextChanged);
            // 
            // btnBuscarVenta
            // 
            this.btnBuscarVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarVenta.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBuscarVenta.Location = new System.Drawing.Point(582, 63);
            this.btnBuscarVenta.Name = "btnBuscarVenta";
            this.btnBuscarVenta.Size = new System.Drawing.Size(94, 31);
            this.btnBuscarVenta.TabIndex = 2;
            this.btnBuscarVenta.Text = "BUSCAR";
            this.btnBuscarVenta.UseVisualStyleBackColor = true;
            this.btnBuscarVenta.Click += new System.EventHandler(this.btnBuscarVenta_Click);
            // 
            // btnCalcularCambio
            // 
            this.btnCalcularCambio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalcularCambio.Location = new System.Drawing.Point(405, 254);
            this.btnCalcularCambio.Name = "btnCalcularCambio";
            this.btnCalcularCambio.Size = new System.Drawing.Size(114, 42);
            this.btnCalcularCambio.TabIndex = 12;
            this.btnCalcularCambio.Text = "CALCULAR CAMBIO";
            this.btnCalcularCambio.UseVisualStyleBackColor = true;
            this.btnCalcularCambio.Click += new System.EventHandler(this.btnCalcularCambio_Click);
            // 
            // btnCalcularTotal
            // 
            this.btnCalcularTotal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalcularTotal.Location = new System.Drawing.Point(248, 254);
            this.btnCalcularTotal.Name = "btnCalcularTotal";
            this.btnCalcularTotal.Size = new System.Drawing.Size(114, 42);
            this.btnCalcularTotal.TabIndex = 47;
            this.btnCalcularTotal.Text = "CALCULAR TOTAL";
            this.btnCalcularTotal.UseVisualStyleBackColor = true;
            this.btnCalcularTotal.Click += new System.EventHandler(this.btnCalcularTotal_Click);
            // 
            // frmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1064, 573);
            this.Controls.Add(this.btnCalcularTotal);
            this.Controls.Add(this.btnCalcularCambio);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtBuscarVenta);
            this.Controls.Add(this.btnBuscarVenta);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtidCliente);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtidProducto);
            this.Controls.Add(this.lblIdVenta);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtCambio);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPagaCon);
            this.Controls.Add(this.dgvVentas);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnVender);
            this.Controls.Add(this.txtNomVentas);
            this.Controls.Add(this.txtNProVentas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPreVentas);
            this.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmVentas";
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.frmVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnVender;
        private System.Windows.Forms.TextBox txtNomVentas;
        private System.Windows.Forms.TextBox txtNProVentas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPreVentas;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.DataGridView dgvVentas;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCambio;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPagaCon;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.Label lblIdVenta;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtidCliente;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtidProducto;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBuscarVenta;
        private System.Windows.Forms.Button btnBuscarVenta;
        private System.Windows.Forms.Button btnCalcularCambio;
        private System.Windows.Forms.Button btnCalcularTotal;
    }
}