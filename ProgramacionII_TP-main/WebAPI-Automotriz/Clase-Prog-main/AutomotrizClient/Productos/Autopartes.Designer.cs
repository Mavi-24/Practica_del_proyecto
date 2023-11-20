namespace AutomotrizClient
{
    partial class Autopartes
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
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.txtPre_unitario = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod_tipo_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod_modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod_tipo_vehiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblModelos = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.gbpMain = new System.Windows.Forms.GroupBox();
            this.cboVehiculos = new System.Windows.Forms.ComboBox();
            this.cboModelos = new System.Windows.Forms.ComboBox();
            this.lblNro = new System.Windows.Forms.Label();
            this.gbpMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(20, 51);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(170, 23);
            this.txtBuscar.TabIndex = 1;
            // 
            // txtPre_unitario
            // 
            this.txtPre_unitario.Location = new System.Drawing.Point(381, 168);
            this.txtPre_unitario.Name = "txtPre_unitario";
            this.txtPre_unitario.Size = new System.Drawing.Size(287, 23);
            this.txtPre_unitario.TabIndex = 4;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(20, 109);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(287, 23);
            this.txtDescripcion.TabIndex = 5;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "cod_producto";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // cod_tipo_producto
            // 
            this.cod_tipo_producto.HeaderText = "cod_tipo_producto";
            this.cod_tipo_producto.Name = "cod_tipo_producto";
            this.cod_tipo_producto.Visible = false;
            // 
            // cod_modelo
            // 
            this.cod_modelo.HeaderText = "cod_modelo";
            this.cod_modelo.Name = "cod_modelo";
            // 
            // color
            // 
            this.color.HeaderText = "color";
            this.color.Name = "color";
            // 
            // cod_tipo_vehiculo
            // 
            this.cod_tipo_vehiculo.HeaderText = "cod_tipo_vehiculo";
            this.cod_tipo_vehiculo.Name = "cod_tipo_vehiculo";
            this.cod_tipo_vehiculo.Visible = false;
            // 
            // precio
            // 
            this.precio.HeaderText = "precio";
            this.precio.Name = "precio";
            // 
            // btnBuscar
            // 
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Location = new System.Drawing.Point(224, 51);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(83, 23);
            this.btnBuscar.TabIndex = 11;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(18, 33);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(46, 15);
            this.lblCodigo.TabIndex = 12;
            this.lblCodigo.Text = "Codigo";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(20, 91);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(69, 15);
            this.lblDescripcion.TabIndex = 13;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(381, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "Tipo Vehiculo";
            // 
            // lblModelos
            // 
            this.lblModelos.AutoSize = true;
            this.lblModelos.Location = new System.Drawing.Point(22, 150);
            this.lblModelos.Name = "lblModelos";
            this.lblModelos.Size = new System.Drawing.Size(48, 15);
            this.lblModelos.TabIndex = 15;
            this.lblModelos.Text = "Modelo";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(381, 150);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(40, 15);
            this.lblPrecio.TabIndex = 16;
            this.lblPrecio.Text = "Precio";
            // 
            // btnNuevo
            // 
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Location = new System.Drawing.Point(256, 306);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 18;
            this.btnNuevo.Text = "Editar";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Location = new System.Drawing.Point(368, 306);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmar.TabIndex = 19;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // gbpMain
            // 
            this.gbpMain.Controls.Add(this.lblNro);
            this.gbpMain.Controls.Add(this.cboVehiculos);
            this.gbpMain.Controls.Add(this.cboModelos);
            this.gbpMain.Controls.Add(this.btnConfirmar);
            this.gbpMain.Controls.Add(this.btnBuscar);
            this.gbpMain.Controls.Add(this.lblCodigo);
            this.gbpMain.Controls.Add(this.lblModelos);
            this.gbpMain.Controls.Add(this.lblPrecio);
            this.gbpMain.Controls.Add(this.label1);
            this.gbpMain.Controls.Add(this.btnNuevo);
            this.gbpMain.Controls.Add(this.txtPre_unitario);
            this.gbpMain.Controls.Add(this.lblDescripcion);
            this.gbpMain.Controls.Add(this.txtDescripcion);
            this.gbpMain.Controls.Add(this.txtBuscar);
            this.gbpMain.Location = new System.Drawing.Point(12, 3);
            this.gbpMain.Name = "gbpMain";
            this.gbpMain.Size = new System.Drawing.Size(699, 370);
            this.gbpMain.TabIndex = 20;
            this.gbpMain.TabStop = false;
            this.gbpMain.Text = "Nueva Autoparte";
            // 
            // cboVehiculos
            // 
            this.cboVehiculos.BackColor = System.Drawing.Color.White;
            this.cboVehiculos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVehiculos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboVehiculos.FormattingEnabled = true;
            this.cboVehiculos.Location = new System.Drawing.Point(381, 109);
            this.cboVehiculos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboVehiculos.Name = "cboVehiculos";
            this.cboVehiculos.Size = new System.Drawing.Size(287, 23);
            this.cboVehiculos.TabIndex = 21;
            // 
            // cboModelos
            // 
            this.cboModelos.BackColor = System.Drawing.Color.White;
            this.cboModelos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboModelos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboModelos.FormattingEnabled = true;
            this.cboModelos.Location = new System.Drawing.Point(22, 168);
            this.cboModelos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboModelos.Name = "cboModelos";
            this.cboModelos.Size = new System.Drawing.Size(285, 23);
            this.cboModelos.TabIndex = 20;
            // 
            // lblNro
            // 
            this.lblNro.AutoSize = true;
            this.lblNro.Location = new System.Drawing.Point(514, 33);
            this.lblNro.Name = "lblNro";
            this.lblNro.Size = new System.Drawing.Size(80, 15);
            this.lblNro.TabIndex = 22;
            this.lblNro.Text = "Autoparte N°:";
            // 
            // Autopartes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(717, 380);
            this.Controls.Add(this.gbpMain);
            this.Name = "Autopartes";
            this.Text = "Autopartes";
            this.Load += new System.EventHandler(this.Autopartes_Load);
            this.gbpMain.ResumeLayout(false);
            this.gbpMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private TextBox txtBuscar;
        private TextBox txtPre_unitario;
        private TextBox txtDescripcion;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn cod_tipo_producto;
        private DataGridViewTextBoxColumn cod_modelo;
        private DataGridViewTextBoxColumn color;
        private DataGridViewTextBoxColumn cod_tipo_vehiculo;
        private DataGridViewTextBoxColumn precio;
        private Button btnBuscar;
        private Label lblCodigo;
        private Label lblDescripcion;
        private Label label1;
        private Label lblModelos;
        private Label lblPrecio;
        private Button btnNuevo;
        private Button btnConfirmar;
        private GroupBox gbpMain;
        private ComboBox cboVehiculos;
        private ComboBox cboModelos;
        private Label lblNro;
    }
}