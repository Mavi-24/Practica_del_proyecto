
namespace AutomotrizClient
{
    partial class FrmFacturas
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
            lblNroFactura = new Label();
            label2 = new Label();
            txtFecha = new TextBox();
            label3 = new Label();
            cboProductos = new ComboBox();
            btnAgregar = new Button();
            txtCantidad = new TextBox();
            btnAceptar = new Button();
            btnCancelar = new Button();
            label6 = new Label();
            txtFinal = new TextBox();
            lblPlan = new Label();
            cboPlan = new ComboBox();
            lblEmpleado = new Label();
            cboEmpleado = new ComboBox();
            btnCerrar = new Button();
            lblCantidad = new Label();
            lblTitulo = new Label();
            BtnConsultar = new Button();
            BtnNuevo = new Button();
            txtNroFactura = new TextBox();
            btnBuscar = new Button();
            rbAutomovil = new RadioButton();
            rbAutoparte = new RadioButton();
            gbCargaProducto = new GroupBox();
            label1 = new Label();
            txtPrecio = new TextBox();
            lblProducto = new Label();
            cboClientes = new ComboBox();
            txtBorrarFact = new TextBox();
            gbBorrar = new GroupBox();
            btnBorrarFactura = new Button();
            lblBorrarFact = new Label();
            btnBorrar = new Button();
            colBorrar = new DataGridViewButtonColumn();
            colPrecio = new DataGridViewTextBoxColumn();
            colCantidad = new DataGridViewTextBoxColumn();
            colProd = new DataGridViewTextBoxColumn();
            colCodigo = new DataGridViewTextBoxColumn();
            dgvDetalles1 = new DataGridView();
            gbCargaProducto.SuspendLayout();
            gbBorrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetalles1).BeginInit();
            SuspendLayout();
            // 
            // lblNroFactura
            // 
            lblNroFactura.AutoSize = true;
            lblNroFactura.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblNroFactura.ForeColor = Color.White;
            lblNroFactura.Location = new Point(43, 63);
            lblNroFactura.Margin = new Padding(4, 0, 4, 0);
            lblNroFactura.Name = "lblNroFactura";
            lblNroFactura.Size = new Size(100, 20);
            lblNroFactura.TabIndex = 1;
            lblNroFactura.Text = "Nº Factura:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(576, 69);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(46, 13);
            label2.TabIndex = 10;
            label2.Text = "Fecha:";
            // 
            // txtFecha
            // 
            txtFecha.Enabled = false;
            txtFecha.Location = new Point(642, 66);
            txtFecha.Margin = new Padding(4, 3, 4, 3);
            txtFecha.MaxLength = 10;
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(186, 23);
            txtFecha.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(65, 163);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(50, 13);
            label3.TabIndex = 6;
            label3.Text = "Cliente:";
            // 
            // cboProductos
            // 
            cboProductos.DropDownStyle = ComboBoxStyle.DropDownList;
            cboProductos.FlatStyle = FlatStyle.Flat;
            cboProductos.FormattingEnabled = true;
            cboProductos.Location = new Point(123, 43);
            cboProductos.Margin = new Padding(4, 3, 4, 3);
            cboProductos.Name = "cboProductos";
            cboProductos.Size = new Size(270, 23);
            cboProductos.TabIndex = 3;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.White;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.ForeColor = Color.Black;
            btnAgregar.Location = new Point(679, 27);
            btnAgregar.Margin = new Padding(4, 3, 4, 3);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(70, 27);
            btnAgregar.TabIndex = 8;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(556, 43);
            txtCantidad.Margin = new Padding(4, 3, 4, 3);
            txtCantidad.MaxLength = 10;
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(65, 23);
            txtCantidad.TabIndex = 7;
            txtCantidad.KeyPress += txtCantidad_KeyPress;
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.White;
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAceptar.Location = new Point(606, 619);
            btnAceptar.Margin = new Padding(4, 3, 4, 3);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(124, 46);
            btnAceptar.TabIndex = 19;
            btnAceptar.Text = "Confirmar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.White;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.Location = new Point(738, 619);
            btnCancelar.Margin = new Padding(4, 3, 4, 3);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(141, 46);
            btnCancelar.TabIndex = 20;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(618, 565);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(69, 20);
            label6.TabIndex = 15;
            label6.Text = " Total $";
            // 
            // txtFinal
            // 
            txtFinal.BackColor = Color.White;
            txtFinal.Enabled = false;
            txtFinal.ForeColor = Color.White;
            txtFinal.Location = new Point(695, 562);
            txtFinal.Margin = new Padding(4, 3, 4, 3);
            txtFinal.MaxLength = 10;
            txtFinal.Name = "txtFinal";
            txtFinal.Size = new Size(109, 23);
            txtFinal.TabIndex = 16;
            // 
            // lblPlan
            // 
            lblPlan.AutoSize = true;
            lblPlan.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblPlan.ForeColor = Color.White;
            lblPlan.Location = new Point(79, 202);
            lblPlan.Margin = new Padding(4, 0, 4, 0);
            lblPlan.Name = "lblPlan";
            lblPlan.Size = new Size(36, 13);
            lblPlan.TabIndex = 8;
            lblPlan.Text = "Plan:";
            // 
            // cboPlan
            // 
            cboPlan.BackColor = Color.White;
            cboPlan.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPlan.FlatStyle = FlatStyle.Flat;
            cboPlan.FormattingEnabled = true;
            cboPlan.Location = new Point(142, 198);
            cboPlan.Margin = new Padding(4, 3, 4, 3);
            cboPlan.Name = "cboPlan";
            cboPlan.Size = new Size(182, 23);
            cboPlan.TabIndex = 9;
            // 
            // lblEmpleado
            // 
            lblEmpleado.AutoSize = true;
            lblEmpleado.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblEmpleado.ForeColor = Color.White;
            lblEmpleado.Location = new Point(49, 121);
            lblEmpleado.Margin = new Padding(4, 0, 4, 0);
            lblEmpleado.Name = "lblEmpleado";
            lblEmpleado.Size = new Size(66, 13);
            lblEmpleado.TabIndex = 4;
            lblEmpleado.Text = "Empleado:";
            // 
            // cboEmpleado
            // 
            cboEmpleado.BackColor = Color.White;
            cboEmpleado.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEmpleado.FlatStyle = FlatStyle.Flat;
            cboEmpleado.FormattingEnabled = true;
            cboEmpleado.Location = new Point(142, 117);
            cboEmpleado.Margin = new Padding(4, 3, 4, 3);
            cboEmpleado.Name = "cboEmpleado";
            cboEmpleado.Size = new Size(182, 23);
            cboEmpleado.TabIndex = 5;
            cboEmpleado.SelectedIndexChanged += cboEmpleado_SelectedIndexChanged;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.White;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Location = new Point(850, 3);
            btnCerrar.Margin = new Padding(4, 3, 4, 3);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(29, 29);
            btnCerrar.TabIndex = 21;
            btnCerrar.Text = "X";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblCantidad.ForeColor = Color.White;
            lblCantidad.Location = new Point(552, 19);
            lblCantidad.Margin = new Padding(4, 0, 4, 0);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(57, 13);
            lblCantidad.TabIndex = 6;
            lblCantidad.Text = "Cantidad";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.White;
            lblTitulo.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.FromArgb(80, 80, 80);
            lblTitulo.Location = new Point(14, 10);
            lblTitulo.Margin = new Padding(4, 0, 4, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(85, 16);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Nueva Venta";
            // 
            // BtnConsultar
            // 
            BtnConsultar.Location = new Point(43, 598);
            BtnConsultar.Margin = new Padding(4, 3, 4, 3);
            BtnConsultar.Name = "BtnConsultar";
            BtnConsultar.Size = new Size(88, 27);
            BtnConsultar.TabIndex = 17;
            BtnConsultar.Text = "Consultar";
            BtnConsultar.UseVisualStyleBackColor = true;
            BtnConsultar.Click += BtnConsultar_Click;
            // 
            // BtnNuevo
            // 
            BtnNuevo.Location = new Point(43, 565);
            BtnNuevo.Margin = new Padding(4, 3, 4, 3);
            BtnNuevo.Name = "BtnNuevo";
            BtnNuevo.Size = new Size(88, 27);
            BtnNuevo.TabIndex = 18;
            BtnNuevo.Text = "Nuevo";
            BtnNuevo.UseVisualStyleBackColor = true;
            BtnNuevo.Click += BtnNuevo_Click;
            // 
            // txtNroFactura
            // 
            txtNroFactura.Location = new Point(142, 602);
            txtNroFactura.Margin = new Padding(4, 3, 4, 3);
            txtNroFactura.Name = "txtNroFactura";
            txtNroFactura.Size = new Size(90, 23);
            txtNroFactura.TabIndex = 2;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(240, 600);
            btnBuscar.Margin = new Padding(4, 3, 4, 3);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(88, 27);
            btnBuscar.TabIndex = 3;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // rbAutomovil
            // 
            rbAutomovil.AutoSize = true;
            rbAutomovil.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            rbAutomovil.ForeColor = Color.White;
            rbAutomovil.Location = new Point(13, 22);
            rbAutomovil.Name = "rbAutomovil";
            rbAutomovil.Size = new Size(83, 19);
            rbAutomovil.TabIndex = 0;
            rbAutomovil.Text = "Automovil";
            rbAutomovil.UseVisualStyleBackColor = true;
            rbAutomovil.CheckedChanged += rbAutomovil_CheckedChanged;
            // 
            // rbAutoparte
            // 
            rbAutoparte.AutoSize = true;
            rbAutoparte.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            rbAutoparte.ForeColor = Color.White;
            rbAutoparte.Location = new Point(13, 47);
            rbAutoparte.Name = "rbAutoparte";
            rbAutoparte.Size = new Size(82, 19);
            rbAutoparte.TabIndex = 1;
            rbAutoparte.Text = "Autoparte";
            rbAutoparte.UseVisualStyleBackColor = true;
            rbAutoparte.CheckedChanged += rbAutoparte_CheckedChanged;
            // 
            // gbCargaProducto
            // 
            gbCargaProducto.Controls.Add(label1);
            gbCargaProducto.Controls.Add(txtPrecio);
            gbCargaProducto.Controls.Add(lblProducto);
            gbCargaProducto.Controls.Add(txtCantidad);
            gbCargaProducto.Controls.Add(rbAutoparte);
            gbCargaProducto.Controls.Add(btnAgregar);
            gbCargaProducto.Controls.Add(rbAutomovil);
            gbCargaProducto.Controls.Add(cboProductos);
            gbCargaProducto.Controls.Add(lblCantidad);
            gbCargaProducto.ForeColor = Color.White;
            gbCargaProducto.Location = new Point(66, 259);
            gbCargaProducto.Name = "gbCargaProducto";
            gbCargaProducto.Size = new Size(762, 77);
            gbCargaProducto.TabIndex = 13;
            gbCargaProducto.TabStop = false;
            gbCargaProducto.Text = "Cargar Producto";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(411, 19);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 4;
            label1.Text = "Precio";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(411, 43);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(100, 23);
            txtPrecio.TabIndex = 5;
            txtPrecio.KeyPress += txtPrecio_KeyPress;
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblProducto.ForeColor = Color.White;
            lblProducto.Location = new Point(123, 19);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(141, 15);
            lblProducto.TabIndex = 2;
            lblProducto.Text = "Seleccione un producto:";
            // 
            // cboClientes
            // 
            cboClientes.DropDownStyle = ComboBoxStyle.DropDownList;
            cboClientes.Enabled = false;
            cboClientes.FlatStyle = FlatStyle.Flat;
            cboClientes.FormattingEnabled = true;
            cboClientes.Location = new Point(140, 159);
            cboClientes.Name = "cboClientes";
            cboClientes.Size = new Size(184, 23);
            cboClientes.TabIndex = 7;
            cboClientes.SelectedIndexChanged += cboClientes_SelectedIndexChanged;
            // 
            // txtBorrarFact
            // 
            txtBorrarFact.Location = new Point(85, 30);
            txtBorrarFact.Name = "txtBorrarFact";
            txtBorrarFact.Size = new Size(102, 23);
            txtBorrarFact.TabIndex = 1;
            // 
            // gbBorrar
            // 
            gbBorrar.Controls.Add(btnBorrarFactura);
            gbBorrar.Controls.Add(lblBorrarFact);
            gbBorrar.Controls.Add(txtBorrarFact);
            gbBorrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            gbBorrar.ForeColor = SystemColors.ButtonHighlight;
            gbBorrar.Location = new Point(335, 558);
            gbBorrar.Name = "gbBorrar";
            gbBorrar.Size = new Size(200, 107);
            gbBorrar.TabIndex = 12;
            gbBorrar.TabStop = false;
            gbBorrar.Text = "Borrar Factura";
            // 
            // btnBorrarFactura
            // 
            btnBorrarFactura.ForeColor = SystemColors.ActiveCaptionText;
            btnBorrarFactura.Location = new Point(112, 72);
            btnBorrarFactura.Name = "btnBorrarFactura";
            btnBorrarFactura.Size = new Size(75, 23);
            btnBorrarFactura.TabIndex = 2;
            btnBorrarFactura.Text = "Aceptar";
            btnBorrarFactura.UseVisualStyleBackColor = true;
            btnBorrarFactura.Click += btnBorrarFactura_Click;
            // 
            // lblBorrarFact
            // 
            lblBorrarFact.AutoSize = true;
            lblBorrarFact.Location = new Point(14, 33);
            lblBorrarFact.Name = "lblBorrarFact";
            lblBorrarFact.Size = new Size(65, 15);
            lblBorrarFact.TabIndex = 0;
            lblBorrarFact.Text = "N° Factura";
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(43, 631);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(88, 27);
            btnBorrar.TabIndex = 22;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // colBorrar
            // 
            colBorrar.HeaderText = "Eliminar";
            colBorrar.Name = "colBorrar";
            colBorrar.ReadOnly = true;
            colBorrar.Resizable = DataGridViewTriState.True;
            colBorrar.SortMode = DataGridViewColumnSortMode.Automatic;
            colBorrar.Text = "Borrar";
            // 
            // colPrecio
            // 
            colPrecio.HeaderText = "Precio";
            colPrecio.Name = "colPrecio";
            colPrecio.ReadOnly = true;
            // 
            // colCantidad
            // 
            colCantidad.HeaderText = "Cantidad";
            colCantidad.Name = "colCantidad";
            colCantidad.ReadOnly = true;
            // 
            // colProd
            // 
            colProd.HeaderText = "Producto";
            colProd.Name = "colProd";
            colProd.ReadOnly = true;
            colProd.Width = 220;
            // 
            // colCodigo
            // 
            colCodigo.HeaderText = "Codigo";
            colCodigo.Name = "colCodigo";
            colCodigo.ReadOnly = true;
            // 
            // dgvDetalles1
            // 
            dgvDetalles1.AllowUserToAddRows = false;
            dgvDetalles1.AllowUserToDeleteRows = false;
            dgvDetalles1.AllowUserToResizeColumns = false;
            dgvDetalles1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalles1.Columns.AddRange(new DataGridViewColumn[] { colCodigo, colProd, colCantidad, colPrecio, colBorrar });
            dgvDetalles1.Location = new Point(66, 350);
            dgvDetalles1.Margin = new Padding(4, 3, 4, 3);
            dgvDetalles1.Name = "dgvDetalles1";
            dgvDetalles1.ReadOnly = true;
            dgvDetalles1.Size = new Size(762, 178);
            dgvDetalles1.TabIndex = 14;
            dgvDetalles1.CellContentClick += dgvDetalles_CellContentClick_1;
            // 
            // FrmFacturas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(894, 690);
            Controls.Add(btnBorrar);
            Controls.Add(gbBorrar);
            Controls.Add(cboClientes);
            Controls.Add(gbCargaProducto);
            Controls.Add(btnBuscar);
            Controls.Add(txtNroFactura);
            Controls.Add(BtnNuevo);
            Controls.Add(BtnConsultar);
            Controls.Add(lblTitulo);
            Controls.Add(btnCerrar);
            Controls.Add(cboEmpleado);
            Controls.Add(lblEmpleado);
            Controls.Add(cboPlan);
            Controls.Add(lblPlan);
            Controls.Add(label6);
            Controls.Add(txtFinal);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(dgvDetalles1);
            Controls.Add(label3);
            Controls.Add(txtFecha);
            Controls.Add(label2);
            Controls.Add(lblNroFactura);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "FrmFacturas";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Nuevo Presupuesto";
            Load += Frm_Facturas_Load_1;
            gbCargaProducto.ResumeLayout(false);
            gbCargaProducto.PerformLayout();
            gbBorrar.ResumeLayout(false);
            gbBorrar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetalles1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblNroFactura;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboProductos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFinal;
        private System.Windows.Forms.Label lblPlan;
        private System.Windows.Forms.ComboBox cboPlan;
        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.ComboBox cboEmpleado;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button BtnConsultar;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.TextBox txtNroFactura;
        private System.Windows.Forms.Button btnBuscar;
        private RadioButton rbAutomovil;
        private RadioButton rbAutoparte;
        private GroupBox gbCargaProducto;
        private Label lblProducto;
        private ComboBox cboClientes;
        private Label label1;
        private TextBox txtPrecio;
        private TextBox txtBorrarFact;
        private GroupBox gbBorrar;
        private Button btnBorrarFactura;
        private Label lblBorrarFact;
        private Button btnBorrar;
        private DataGridViewButtonColumn colBorrar;
        private DataGridViewTextBoxColumn colPrecio;
        private DataGridViewTextBoxColumn colCantidad;
        private DataGridViewTextBoxColumn colProd;
        private DataGridViewTextBoxColumn colCodigo;
        private DataGridView dgvDetalles1;
    }
}