
namespace Refaccionaria_Terry
{
    partial class frmClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClientes));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomClientes = new System.Windows.Forms.TextBox();
            this.txtDescuentos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTelClientes = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRegClientes = new System.Windows.Forms.Button();
            this.txtPriApellido = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSegApellido = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtComTotales = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.btnBusClientes = new System.Windows.Forms.Button();
            this.txtBusClientes = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblidCliente = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(426, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 40);
            this.label1.TabIndex = 23;
            this.label1.Text = "CLIENTES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(6, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 19);
            this.label2.TabIndex = 24;
            this.label2.Text = "NOMBRE:";
            // 
            // txtNomClientes
            // 
            this.txtNomClientes.Location = new System.Drawing.Point(90, 38);
            this.txtNomClientes.Name = "txtNomClientes";
            this.txtNomClientes.Size = new System.Drawing.Size(237, 27);
            this.txtNomClientes.TabIndex = 1;
            this.txtNomClientes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomClientes_KeyPress);
            // 
            // txtDescuentos
            // 
            this.txtDescuentos.Location = new System.Drawing.Point(122, 129);
            this.txtDescuentos.Name = "txtDescuentos";
            this.txtDescuentos.Size = new System.Drawing.Size(101, 27);
            this.txtDescuentos.TabIndex = 5;
            this.txtDescuentos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescuentos_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(6, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 19);
            this.label3.TabIndex = 26;
            this.label3.Text = "DESCUENTOS:";
            // 
            // txtTelClientes
            // 
            this.txtTelClientes.Location = new System.Drawing.Point(431, 83);
            this.txtTelClientes.Name = "txtTelClientes";
            this.txtTelClientes.Size = new System.Drawing.Size(218, 27);
            this.txtTelClientes.TabIndex = 4;
            this.txtTelClientes.Validated += new System.EventHandler(this.txtTelClientes_Validated);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(336, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 19);
            this.label4.TabIndex = 28;
            this.label4.Text = "TELÉFONO:";
            // 
            // btnRegClientes
            // 
            this.btnRegClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegClientes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRegClientes.Location = new System.Drawing.Point(125, 281);
            this.btnRegClientes.Name = "btnRegClientes";
            this.btnRegClientes.Size = new System.Drawing.Size(154, 28);
            this.btnRegClientes.TabIndex = 7;
            this.btnRegClientes.Text = "REGISTRAR";
            this.btnRegClientes.UseVisualStyleBackColor = true;
            this.btnRegClientes.Click += new System.EventHandler(this.btnRegClientes_Click);
            // 
            // txtPriApellido
            // 
            this.txtPriApellido.Location = new System.Drawing.Point(483, 33);
            this.txtPriApellido.Name = "txtPriApellido";
            this.txtPriApellido.Size = new System.Drawing.Size(166, 27);
            this.txtPriApellido.TabIndex = 2;
            this.txtPriApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPriApellido_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(336, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 19);
            this.label5.TabIndex = 33;
            this.label5.Text = "PRIMER APELLIDO:";
            // 
            // txtSegApellido
            // 
            this.txtSegApellido.Location = new System.Drawing.Point(175, 83);
            this.txtSegApellido.Name = "txtSegApellido";
            this.txtSegApellido.Size = new System.Drawing.Size(152, 27);
            this.txtSegApellido.TabIndex = 3;
            this.txtSegApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSegApellido_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(6, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 19);
            this.label6.TabIndex = 35;
            this.label6.Text = "SEGUNDO APELLIDO:";
            // 
            // txtComTotales
            // 
            this.txtComTotales.Location = new System.Drawing.Point(409, 129);
            this.txtComTotales.Name = "txtComTotales";
            this.txtComTotales.Size = new System.Drawing.Size(166, 27);
            this.txtComTotales.TabIndex = 6;
            this.txtComTotales.Validated += new System.EventHandler(this.txtComTotales_Validated);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(247, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 19);
            this.label7.TabIndex = 37;
            this.label7.Text = "COMPRAS TOTALES:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.txtComTotales);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtSegApellido);
            this.groupBox2.Controls.Add(this.txtNomClientes);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtPriApellido);
            this.groupBox2.Controls.Add(this.txtDescuentos);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtTelClientes);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(141, 104);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(674, 171);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DATOS";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEliminar.Location = new System.Drawing.Point(801, 281);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(154, 28);
            this.btnEliminar.TabIndex = 17;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnActualizar.Location = new System.Drawing.Point(453, 281);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(154, 28);
            this.btnActualizar.TabIndex = 16;
            this.btnActualizar.Text = "ACTUALIZAR";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(115, 315);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.Size = new System.Drawing.Size(814, 219);
            this.dgvClientes.TabIndex = 39;
            this.dgvClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellContentClick);
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(47, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 19);
            this.label10.TabIndex = 1;
            this.label10.Text = "BUSCAR CLIENTE:";
            // 
            // btnBusClientes
            // 
            this.btnBusClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBusClientes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBusClientes.Location = new System.Drawing.Point(400, 55);
            this.btnBusClientes.Name = "btnBusClientes";
            this.btnBusClientes.Size = new System.Drawing.Size(94, 31);
            this.btnBusClientes.TabIndex = 9;
            this.btnBusClientes.Text = "BUSCAR";
            this.btnBusClientes.UseVisualStyleBackColor = true;
            this.btnBusClientes.Click += new System.EventHandler(this.btnBusClientes_Click);
            // 
            // txtBusClientes
            // 
            this.txtBusClientes.Location = new System.Drawing.Point(188, 59);
            this.txtBusClientes.Name = "txtBusClientes";
            this.txtBusClientes.Size = new System.Drawing.Size(206, 23);
            this.txtBusClientes.TabIndex = 8;
            this.txtBusClientes.TextChanged += new System.EventHandler(this.txtBusClientes_TextChanged);
            this.txtBusClientes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBusClientes_KeyPress);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // errorProvider4
            // 
            this.errorProvider4.ContainerControl = this;
            // 
            // lblidCliente
            // 
            this.lblidCliente.AutoSize = true;
            this.lblidCliente.Location = new System.Drawing.Point(61, 13);
            this.lblidCliente.Name = "lblidCliente";
            this.lblidCliente.Size = new System.Drawing.Size(13, 15);
            this.lblidCliente.TabIndex = 40;
            this.lblidCliente.Text = "0";
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1064, 573);
            this.Controls.Add(this.lblidCliente);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnRegClientes);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnBusClientes);
            this.Controls.Add(this.txtBusClientes);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmClientes";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.frmClientes_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomClientes;
        private System.Windows.Forms.TextBox txtDescuentos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTelClientes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRegClientes;
        private System.Windows.Forms.TextBox txtPriApellido;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSegApellido;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtComTotales;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnBusClientes;
        private System.Windows.Forms.TextBox txtBusClientes;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.Label lblidCliente;
    }
}