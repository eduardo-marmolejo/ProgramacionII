
namespace Refaccionaria_Terry
{
    partial class frmEmpleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmpleados));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomEmpleado = new System.Windows.Forms.TextBox();
            this.txtTelEmpleado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRegEmpleado = new System.Windows.Forms.Button();
            this.txtPriApEmpleado = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSegApEmpleado = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCurp = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtidDireccion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtidLogin = new System.Windows.Forms.TextBox();
            this.btnEliminarEmpleado = new System.Windows.Forms.Button();
            this.btnActualizarEmpleado = new System.Windows.Forms.Button();
            this.dgvEmpleado = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.btnBusEmpleado = new System.Windows.Forms.Button();
            this.txtBusEmpleado = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblidEmpleado = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(416, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 40);
            this.label1.TabIndex = 25;
            this.label1.Text = "EMPLEADOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(70, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 19);
            this.label2.TabIndex = 26;
            this.label2.Text = "NOM. EMPLEADO:";
            // 
            // txtNomEmpleado
            // 
            this.txtNomEmpleado.Location = new System.Drawing.Point(218, 24);
            this.txtNomEmpleado.Name = "txtNomEmpleado";
            this.txtNomEmpleado.Size = new System.Drawing.Size(261, 27);
            this.txtNomEmpleado.TabIndex = 3;
            this.txtNomEmpleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomEmpleado_KeyPress);
            // 
            // txtTelEmpleado
            // 
            this.txtTelEmpleado.Location = new System.Drawing.Point(218, 140);
            this.txtTelEmpleado.Name = "txtTelEmpleado";
            this.txtTelEmpleado.Size = new System.Drawing.Size(261, 27);
            this.txtTelEmpleado.TabIndex = 7;
            this.txtTelEmpleado.Validated += new System.EventHandler(this.txtTelEmpleado_Validated);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(123, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 19);
            this.label4.TabIndex = 30;
            this.label4.Text = "TELÉFONO:";
            // 
            // btnRegEmpleado
            // 
            this.btnRegEmpleado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegEmpleado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRegEmpleado.Location = new System.Drawing.Point(230, 298);
            this.btnRegEmpleado.Name = "btnRegEmpleado";
            this.btnRegEmpleado.Size = new System.Drawing.Size(116, 28);
            this.btnRegEmpleado.TabIndex = 10;
            this.btnRegEmpleado.Text = "REGISTRAR";
            this.btnRegEmpleado.UseVisualStyleBackColor = true;
            this.btnRegEmpleado.Click += new System.EventHandler(this.btnRegEmpleado_Click);
            // 
            // txtPriApEmpleado
            // 
            this.txtPriApEmpleado.Location = new System.Drawing.Point(218, 53);
            this.txtPriApEmpleado.Name = "txtPriApEmpleado";
            this.txtPriApEmpleado.Size = new System.Drawing.Size(261, 27);
            this.txtPriApEmpleado.TabIndex = 4;
            this.txtPriApEmpleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPriApEmpleado_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(70, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 19);
            this.label5.TabIndex = 36;
            this.label5.Text = "PRIMER APELLIDO:";
            // 
            // txtSegApEmpleado
            // 
            this.txtSegApEmpleado.Location = new System.Drawing.Point(218, 82);
            this.txtSegApEmpleado.Name = "txtSegApEmpleado";
            this.txtSegApEmpleado.Size = new System.Drawing.Size(261, 27);
            this.txtSegApEmpleado.TabIndex = 5;
            this.txtSegApEmpleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSegApEmpleado_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(49, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 19);
            this.label6.TabIndex = 38;
            this.label6.Text = "SEGUNDO APELLIDO:";
            // 
            // txtCurp
            // 
            this.txtCurp.Location = new System.Drawing.Point(218, 111);
            this.txtCurp.Name = "txtCurp";
            this.txtCurp.Size = new System.Drawing.Size(261, 27);
            this.txtCurp.TabIndex = 6;
            this.txtCurp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCurp_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(158, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 19);
            this.label7.TabIndex = 40;
            this.label7.Text = "CURP:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtidDireccion);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtidLogin);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtNomEmpleado);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtTelEmpleado);
            this.groupBox2.Controls.Add(this.txtCurp);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtPriApEmpleado);
            this.groupBox2.Controls.Add(this.txtSegApEmpleado);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(152, 97);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(777, 183);
            this.groupBox2.TabIndex = 42;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DATOS";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(485, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 19);
            this.label8.TabIndex = 44;
            this.label8.Text = "DIRECCIÓN:";
            // 
            // txtidDireccion
            // 
            this.txtidDireccion.Location = new System.Drawing.Point(589, 99);
            this.txtidDireccion.Name = "txtidDireccion";
            this.txtidDireccion.Size = new System.Drawing.Size(116, 27);
            this.txtidDireccion.TabIndex = 9;
            this.txtidDireccion.Validated += new System.EventHandler(this.txtidDireccion_Validated);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(485, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 19);
            this.label3.TabIndex = 42;
            this.label3.Text = "LOGIN:";
            // 
            // txtidLogin
            // 
            this.txtidLogin.Location = new System.Drawing.Point(553, 66);
            this.txtidLogin.Name = "txtidLogin";
            this.txtidLogin.Size = new System.Drawing.Size(152, 27);
            this.txtidLogin.TabIndex = 8;
            this.txtidLogin.Validated += new System.EventHandler(this.txtidLogin_Validated);
            // 
            // btnEliminarEmpleado
            // 
            this.btnEliminarEmpleado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarEmpleado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEliminarEmpleado.Location = new System.Drawing.Point(724, 298);
            this.btnEliminarEmpleado.Name = "btnEliminarEmpleado";
            this.btnEliminarEmpleado.Size = new System.Drawing.Size(101, 28);
            this.btnEliminarEmpleado.TabIndex = 12;
            this.btnEliminarEmpleado.Text = "ELIMINAR";
            this.btnEliminarEmpleado.UseVisualStyleBackColor = true;
            this.btnEliminarEmpleado.Click += new System.EventHandler(this.btnEliminarEmpleado_Click);
            // 
            // btnActualizarEmpleado
            // 
            this.btnActualizarEmpleado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizarEmpleado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnActualizarEmpleado.Location = new System.Drawing.Point(483, 298);
            this.btnActualizarEmpleado.Name = "btnActualizarEmpleado";
            this.btnActualizarEmpleado.Size = new System.Drawing.Size(123, 28);
            this.btnActualizarEmpleado.TabIndex = 11;
            this.btnActualizarEmpleado.Text = "ACTUALIZAR";
            this.btnActualizarEmpleado.UseVisualStyleBackColor = true;
            this.btnActualizarEmpleado.Click += new System.EventHandler(this.btnActualizarEmpleado_Click);
            // 
            // dgvEmpleado
            // 
            this.dgvEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleado.Location = new System.Drawing.Point(152, 342);
            this.dgvEmpleado.Name = "dgvEmpleado";
            this.dgvEmpleado.RowTemplate.Height = 25;
            this.dgvEmpleado.Size = new System.Drawing.Size(777, 219);
            this.dgvEmpleado.TabIndex = 12;
            this.dgvEmpleado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpleado_CellContentClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(87, 72);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(159, 19);
            this.label10.TabIndex = 1;
            this.label10.Text = "BUSCAR EMPLEADO:";
            // 
            // btnBusEmpleado
            // 
            this.btnBusEmpleado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBusEmpleado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBusEmpleado.Location = new System.Drawing.Point(483, 66);
            this.btnBusEmpleado.Name = "btnBusEmpleado";
            this.btnBusEmpleado.Size = new System.Drawing.Size(94, 25);
            this.btnBusEmpleado.TabIndex = 2;
            this.btnBusEmpleado.Text = "BUSCAR";
            this.btnBusEmpleado.UseVisualStyleBackColor = true;
            this.btnBusEmpleado.Click += new System.EventHandler(this.btnBusEmpleado_Click);
            // 
            // txtBusEmpleado
            // 
            this.txtBusEmpleado.Location = new System.Drawing.Point(252, 68);
            this.txtBusEmpleado.Name = "txtBusEmpleado";
            this.txtBusEmpleado.Size = new System.Drawing.Size(225, 23);
            this.txtBusEmpleado.TabIndex = 1;
            this.txtBusEmpleado.TextChanged += new System.EventHandler(this.txtBusEmpleado_TextChanged);
            this.txtBusEmpleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBusEmpleado_KeyPress);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // lblidEmpleado
            // 
            this.lblidEmpleado.AutoSize = true;
            this.lblidEmpleado.Location = new System.Drawing.Point(44, 33);
            this.lblidEmpleado.Name = "lblidEmpleado";
            this.lblidEmpleado.Size = new System.Drawing.Size(13, 15);
            this.lblidEmpleado.TabIndex = 43;
            this.lblidEmpleado.Text = "0";
            // 
            // frmEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1064, 573);
            this.Controls.Add(this.lblidEmpleado);
            this.Controls.Add(this.dgvEmpleado);
            this.Controls.Add(this.btnEliminarEmpleado);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnActualizarEmpleado);
            this.Controls.Add(this.btnRegEmpleado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnBusEmpleado);
            this.Controls.Add(this.txtBusEmpleado);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEmpleados";
            this.Text = "Empleados";
            this.Load += new System.EventHandler(this.frmEmpleados_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomEmpleado;
        private System.Windows.Forms.TextBox txtTelEmpleado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRegEmpleado;
        private System.Windows.Forms.TextBox txtPriApEmpleado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSegApEmpleado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCurp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnEliminarEmpleado;
        private System.Windows.Forms.Button btnActualizarEmpleado;
        private System.Windows.Forms.DataGridView dgvEmpleado;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnBusEmpleado;
        private System.Windows.Forms.TextBox txtBusEmpleado;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtidDireccion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtidLogin;
        private System.Windows.Forms.Label lblidEmpleado;
    }
}