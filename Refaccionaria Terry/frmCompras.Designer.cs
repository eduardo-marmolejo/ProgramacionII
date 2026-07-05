
namespace Refaccionaria_Terry
{
    partial class frmCompras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCompras));
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnComprar = new System.Windows.Forms.Button();
            this.txtNomCompras = new System.Windows.Forms.TextBox();
            this.txtNumProductos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrecioCom = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtidProducto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtidProveedor = new System.Windows.Forms.TextBox();
            this.dgvCompras = new System.Windows.Forms.DataGridView();
            this.lblidCompra = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompras)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(408, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 40);
            this.label1.TabIndex = 24;
            this.label1.Text = "COMPRAS";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(420, 184);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(102, 23);
            this.dtpFecha.TabIndex = 4;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotal.Location = new System.Drawing.Point(631, 184);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(18, 19);
            this.lblTotal.TabIndex = 43;
            this.lblTotal.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(350, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 19);
            this.label6.TabIndex = 42;
            this.label6.Text = "FECHA:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(566, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 19);
            this.label5.TabIndex = 41;
            this.label5.Text = "TOTAL:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(350, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 19);
            this.label2.TabIndex = 34;
            this.label2.Text = "NOMBRE:";
            // 
            // btnComprar
            // 
            this.btnComprar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnComprar.Location = new System.Drawing.Point(542, 244);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(310, 34);
            this.btnComprar.TabIndex = 8;
            this.btnComprar.Text = "COMPRAR";
            this.btnComprar.UseVisualStyleBackColor = true;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // txtNomCompras
            // 
            this.txtNomCompras.Location = new System.Drawing.Point(435, 72);
            this.txtNomCompras.Name = "txtNomCompras";
            this.txtNomCompras.Size = new System.Drawing.Size(225, 23);
            this.txtNomCompras.TabIndex = 1;
            this.txtNomCompras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomCompras_KeyPress);
            // 
            // txtNumProductos
            // 
            this.txtNumProductos.Location = new System.Drawing.Point(505, 146);
            this.txtNumProductos.Name = "txtNumProductos";
            this.txtNumProductos.Size = new System.Drawing.Size(155, 23);
            this.txtNumProductos.TabIndex = 3;
            this.txtNumProductos.Validated += new System.EventHandler(this.txtNumProductos_Validated);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(350, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 19);
            this.label3.TabIndex = 36;
            this.label3.Text = "PRECIO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(350, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 19);
            this.label4.TabIndex = 38;
            this.label4.Text = "NUM. PRODUCTOS:";
            // 
            // txtPrecioCom
            // 
            this.txtPrecioCom.Location = new System.Drawing.Point(435, 108);
            this.txtPrecioCom.Name = "txtPrecioCom";
            this.txtPrecioCom.Size = new System.Drawing.Size(225, 23);
            this.txtPrecioCom.TabIndex = 2;
            this.txtPrecioCom.Validated += new System.EventHandler(this.txtPrecioCom_Validated);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalcular.Location = new System.Drawing.Point(183, 244);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(310, 34);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "CALCULAR";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(270, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 19);
            this.label7.TabIndex = 45;
            this.label7.Text = "PRODUCTO:";
            // 
            // txtidProducto
            // 
            this.txtidProducto.Location = new System.Drawing.Point(373, 215);
            this.txtidProducto.Name = "txtidProducto";
            this.txtidProducto.Size = new System.Drawing.Size(100, 23);
            this.txtidProducto.TabIndex = 5;
            this.txtidProducto.Validated += new System.EventHandler(this.txtidProducto_Validated);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(521, 214);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 19);
            this.label8.TabIndex = 47;
            this.label8.Text = "PROVEEDOR:";
            // 
            // txtidProveedor
            // 
            this.txtidProveedor.Location = new System.Drawing.Point(624, 215);
            this.txtidProveedor.Name = "txtidProveedor";
            this.txtidProveedor.Size = new System.Drawing.Size(100, 23);
            this.txtidProveedor.TabIndex = 6;
            this.txtidProveedor.Validated += new System.EventHandler(this.txtidProveedor_Validated);
            // 
            // dgvCompras
            // 
            this.dgvCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompras.Location = new System.Drawing.Point(163, 307);
            this.dgvCompras.Name = "dgvCompras";
            this.dgvCompras.RowTemplate.Height = 25;
            this.dgvCompras.Size = new System.Drawing.Size(734, 220);
            this.dgvCompras.TabIndex = 9;
            this.dgvCompras.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCompras_CellContentClick);
            // 
            // lblidCompra
            // 
            this.lblidCompra.AutoSize = true;
            this.lblidCompra.Location = new System.Drawing.Point(137, 33);
            this.lblidCompra.Name = "lblidCompra";
            this.lblidCompra.Size = new System.Drawing.Size(13, 15);
            this.lblidCompra.TabIndex = 48;
            this.lblidCompra.Text = "0";
            // 
            // frmCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1064, 573);
            this.Controls.Add(this.lblidCompra);
            this.Controls.Add(this.dgvCompras);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtidProveedor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtidProducto);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnComprar);
            this.Controls.Add(this.txtNomCompras);
            this.Controls.Add(this.txtNumProductos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPrecioCom);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCompras";
            this.Text = "Compras";
            this.Load += new System.EventHandler(this.frmCompras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.TextBox txtNomCompras;
        private System.Windows.Forms.TextBox txtNumProductos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrecioCom;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtidProveedor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtidProducto;
        private System.Windows.Forms.DataGridView dgvCompras;
        private System.Windows.Forms.Label lblidCompra;
    }
}