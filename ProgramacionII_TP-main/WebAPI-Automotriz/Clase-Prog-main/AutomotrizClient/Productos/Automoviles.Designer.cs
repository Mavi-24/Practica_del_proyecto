namespace AutomotrizClient.Productos
{
    partial class Automoviles
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
            gpbMain = new GroupBox();
            lblNro = new Label();
            btnConfirmar = new Button();
            btnNuevo = new Button();
            btnBuscar = new Button();
            lblCodigo = new Label();
            lblVehiculo = new Label();
            lblPrecio = new Label();
            lblModelo = new Label();
            cboVehiculos = new ComboBox();
            txtModelo = new TextBox();
            txtPre_unitario = new TextBox();
            txtBuscar = new TextBox();
            gpbMain.SuspendLayout();
            SuspendLayout();
            // 
            // gpbMain
            // 
            gpbMain.Controls.Add(lblNro);
            gpbMain.Controls.Add(btnConfirmar);
            gpbMain.Controls.Add(btnNuevo);
            gpbMain.Controls.Add(btnBuscar);
            gpbMain.Controls.Add(lblCodigo);
            gpbMain.Controls.Add(lblVehiculo);
            gpbMain.Controls.Add(lblPrecio);
            gpbMain.Controls.Add(lblModelo);
            gpbMain.Controls.Add(cboVehiculos);
            gpbMain.Controls.Add(txtModelo);
            gpbMain.Controls.Add(txtPre_unitario);
            gpbMain.Controls.Add(txtBuscar);
            gpbMain.Location = new Point(12, 12);
            gpbMain.Name = "gpbMain";
            gpbMain.Size = new Size(647, 310);
            gpbMain.TabIndex = 0;
            gpbMain.TabStop = false;
            gpbMain.Text = "Nuevo Automovil";
            gpbMain.Enter += gpbMain_Enter;
            // 
            // lblNro
            // 
            lblNro.AutoSize = true;
            lblNro.Location = new Point(499, 19);
            lblNro.Name = "lblNro";
            lblNro.Size = new Size(83, 15);
            lblNro.TabIndex = 30;
            lblNro.Text = "Automovil N°:";
            // 
            // btnConfirmar
            // 
            btnConfirmar.FlatStyle = FlatStyle.Flat;
            btnConfirmar.Location = new Point(341, 267);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(83, 23);
            btnConfirmar.TabIndex = 29;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.FlatStyle = FlatStyle.Flat;
            btnNuevo.Location = new Point(227, 267);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(83, 23);
            btnNuevo.TabIndex = 28;
            btnNuevo.Text = "Editar";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Location = new Point(166, 53);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(83, 23);
            btnBuscar.TabIndex = 27;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(41, 36);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(42, 15);
            lblCodigo.TabIndex = 26;
            lblCodigo.Text = "Legajo";
            // 
            // lblVehiculo
            // 
            lblVehiculo.AutoSize = true;
            lblVehiculo.Location = new Point(341, 114);
            lblVehiculo.Name = "lblVehiculo";
            lblVehiculo.Size = new Size(78, 15);
            lblVehiculo.TabIndex = 25;
            lblVehiculo.Text = "Tipo Vehiculo";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(41, 175);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(40, 15);
            lblPrecio.TabIndex = 24;
            lblPrecio.Text = "Precio";
            // 
            // lblModelo
            // 
            lblModelo.AutoSize = true;
            lblModelo.Location = new Point(41, 114);
            lblModelo.Name = "lblModelo";
            lblModelo.Size = new Size(51, 15);
            lblModelo.TabIndex = 23;
            lblModelo.Text = "Nombre";
            // 
            // cboVehiculos
            // 
            cboVehiculos.BackColor = Color.White;
            cboVehiculos.DropDownStyle = ComboBoxStyle.DropDownList;
            cboVehiculos.FlatStyle = FlatStyle.Flat;
            cboVehiculos.FormattingEnabled = true;
            cboVehiculos.Location = new Point(341, 132);
            cboVehiculos.Margin = new Padding(4, 3, 4, 3);
            cboVehiculos.Name = "cboVehiculos";
            cboVehiculos.Size = new Size(238, 23);
            cboVehiculos.TabIndex = 22;
            cboVehiculos.SelectedIndexChanged += cboVehiculos_SelectedIndexChanged;
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(41, 132);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(208, 23);
            txtModelo.TabIndex = 2;
            // 
            // txtPre_unitario
            // 
            txtPre_unitario.Location = new Point(41, 193);
            txtPre_unitario.Name = "txtPre_unitario";
            txtPre_unitario.Size = new Size(208, 23);
            txtPre_unitario.TabIndex = 1;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(41, 54);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(100, 23);
            txtBuscar.TabIndex = 0;
            // 
            // Automoviles
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(671, 334);
            Controls.Add(gpbMain);
            Name = "Automoviles";
            Text = "Automoviles";
            Load += Automoviles_Load;
            gpbMain.ResumeLayout(false);
            gpbMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gpbMain;
        private TextBox txtModelo;
        private TextBox txtPre_unitario;
        private TextBox txtBuscar;
        private Label lblCodigo;
        private Label lblVehiculo;
        private Label lblPrecio;
        private Label lblModelo;
        private ComboBox cboVehiculos;
        private Button btnConfirmar;
        private Button btnNuevo;
        private Button btnBuscar;
        private Label lblNro;
    }
}