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
            this.gpbMain = new System.Windows.Forms.GroupBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblVehiculo = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.cboVehiculos = new System.Windows.Forms.ComboBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtPre_unitario = new System.Windows.Forms.TextBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblNro = new System.Windows.Forms.Label();
            this.gpbMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbMain
            // 
            this.gpbMain.Controls.Add(this.lblNro);
            this.gpbMain.Controls.Add(this.btnConfirmar);
            this.gpbMain.Controls.Add(this.btnNuevo);
            this.gpbMain.Controls.Add(this.btnBuscar);
            this.gpbMain.Controls.Add(this.lblCodigo);
            this.gpbMain.Controls.Add(this.lblVehiculo);
            this.gpbMain.Controls.Add(this.lblPrecio);
            this.gpbMain.Controls.Add(this.lblModelo);
            this.gpbMain.Controls.Add(this.cboVehiculos);
            this.gpbMain.Controls.Add(this.txtModelo);
            this.gpbMain.Controls.Add(this.txtPre_unitario);
            this.gpbMain.Controls.Add(this.txtBuscar);
            this.gpbMain.Location = new System.Drawing.Point(12, 12);
            this.gpbMain.Name = "gpbMain";
            this.gpbMain.Size = new System.Drawing.Size(647, 310);
            this.gpbMain.TabIndex = 0;
            this.gpbMain.TabStop = false;
            this.gpbMain.Text = "Nuevo Automovil";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Location = new System.Drawing.Point(341, 267);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(83, 23);
            this.btnConfirmar.TabIndex = 29;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Location = new System.Drawing.Point(227, 267);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(83, 23);
            this.btnNuevo.TabIndex = 28;
            this.btnNuevo.Text = "Editar";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Location = new System.Drawing.Point(166, 53);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(83, 23);
            this.btnBuscar.TabIndex = 27;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(41, 36);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(46, 15);
            this.lblCodigo.TabIndex = 26;
            this.lblCodigo.Text = "Codigo";
            // 
            // lblVehiculo
            // 
            this.lblVehiculo.AutoSize = true;
            this.lblVehiculo.Location = new System.Drawing.Point(341, 114);
            this.lblVehiculo.Name = "lblVehiculo";
            this.lblVehiculo.Size = new System.Drawing.Size(78, 15);
            this.lblVehiculo.TabIndex = 25;
            this.lblVehiculo.Text = "Tipo Vehiculo";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(41, 175);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(40, 15);
            this.lblPrecio.TabIndex = 24;
            this.lblPrecio.Text = "Precio";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(41, 114);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(48, 15);
            this.lblModelo.TabIndex = 23;
            this.lblModelo.Text = "Modelo";
            // 
            // cboVehiculos
            // 
            this.cboVehiculos.BackColor = System.Drawing.Color.White;
            this.cboVehiculos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVehiculos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboVehiculos.FormattingEnabled = true;
            this.cboVehiculos.Location = new System.Drawing.Point(341, 132);
            this.cboVehiculos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboVehiculos.Name = "cboVehiculos";
            this.cboVehiculos.Size = new System.Drawing.Size(238, 23);
            this.cboVehiculos.TabIndex = 22;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(41, 132);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(208, 23);
            this.txtModelo.TabIndex = 2;
            // 
            // txtPre_unitario
            // 
            this.txtPre_unitario.Location = new System.Drawing.Point(41, 193);
            this.txtPre_unitario.Name = "txtPre_unitario";
            this.txtPre_unitario.Size = new System.Drawing.Size(208, 23);
            this.txtPre_unitario.TabIndex = 1;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(41, 54);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(100, 23);
            this.txtBuscar.TabIndex = 0;
            // 
            // lblNro
            // 
            this.lblNro.AutoSize = true;
            this.lblNro.Location = new System.Drawing.Point(499, 19);
            this.lblNro.Name = "lblNro";
            this.lblNro.Size = new System.Drawing.Size(83, 15);
            this.lblNro.TabIndex = 30;
            this.lblNro.Text = "Automovil N°:";
            // 
            // Automoviles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(671, 334);
            this.Controls.Add(this.gpbMain);
            this.Name = "Automoviles";
            this.Text = "Automoviles";
            this.Load += new System.EventHandler(this.Automoviles_Load);
            this.gpbMain.ResumeLayout(false);
            this.gpbMain.PerformLayout();
            this.ResumeLayout(false);

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