namespace AutomotrizClient.Productos
{
    partial class Empleados
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
            components = new System.ComponentModel.Container();
            label2 = new Label();
            label3 = new Label();
            txtNombre = new TextBox();
            cboEmpleado = new ComboBox();
            empleadoBindingSource4 = new BindingSource(components);
            empleadoBindingSource3 = new BindingSource(components);
            empleadoBindingSource = new BindingSource(components);
            empleadoBindingSource1 = new BindingSource(components);
            empleadoBindingSource2 = new BindingSource(components);
            button2 = new Button();
            button3 = new Button();
            menuStrip1 = new MenuStrip();
            toolStripTextBox1 = new ToolStripTextBox();
            ((System.ComponentModel.ISupportInitialize)empleadoBindingSource4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)empleadoBindingSource3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)empleadoBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)empleadoBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)empleadoBindingSource2).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 64);
            label2.Name = "label2";
            label2.Size = new Size(107, 15);
            label2.TabIndex = 2;
            label2.Text = "Nombre y Apellido";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 135);
            label3.Name = "label3";
            label3.Size = new Size(102, 15);
            label3.TabIndex = 3;
            label3.Text = "Tipo de Empleado";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(33, 93);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(140, 23);
            txtNombre.TabIndex = 5;
            // 
            // cboEmpleado
            // 
            cboEmpleado.FormattingEnabled = true;
            cboEmpleado.Location = new Point(33, 165);
            cboEmpleado.Name = "cboEmpleado";
            cboEmpleado.Size = new Size(137, 23);
            cboEmpleado.TabIndex = 6;
            // 
            // empleadoBindingSource4
            // 
            empleadoBindingSource4.DataSource = typeof(Libreria.Dominio.Empleado);
            // 
            // empleadoBindingSource3
            // 
            empleadoBindingSource3.DataSource = typeof(Libreria.Dominio.Empleado);
            // 
            // empleadoBindingSource
            // 
            empleadoBindingSource.DataSource = typeof(Libreria.Dominio.Empleado);
            // 
            // empleadoBindingSource1
            // 
            empleadoBindingSource1.DataSource = typeof(Libreria.Dominio.Empleado);
            // 
            // empleadoBindingSource2
            // 
            empleadoBindingSource2.DataSource = typeof(Libreria.Dominio.Empleado);
            // 
            // button2
            // 
            button2.Location = new Point(33, 217);
            button2.Name = "button2";
            button2.Size = new Size(91, 33);
            button2.TabIndex = 7;
            button2.Text = "Nuevo";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(130, 217);
            button3.Name = "button3";
            button3.Size = new Size(93, 33);
            button3.TabIndex = 8;
            button3.Text = "Cerrar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripTextBox1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(235, 27);
            menuStrip1.TabIndex = 9;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripTextBox1
            // 
            toolStripTextBox1.Name = "toolStripTextBox1";
            toolStripTextBox1.Size = new Size(120, 23);
            toolStripTextBox1.Text = "Salir del Programa";
            toolStripTextBox1.Click += toolStripTextBox1_Click;
            // 
            // Empleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(235, 295);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(cboEmpleado);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Empleados";
            Text = "Empleados";
            Load += Empleados_Load;
            ((System.ComponentModel.ISupportInitialize)empleadoBindingSource4).EndInit();
            ((System.ComponentModel.ISupportInitialize)empleadoBindingSource3).EndInit();
            ((System.ComponentModel.ISupportInitialize)empleadoBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)empleadoBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)empleadoBindingSource2).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private TextBox txtNombre;
        private ComboBox cboEmpleado;
        private BindingSource empleadoBindingSource;
        private BindingSource empleadoBindingSource1;
        private BindingSource empleadoBindingSource3;
        private BindingSource empleadoBindingSource2;
        private BindingSource empleadoBindingSource4;
        private Button button2;
        private Button button3;
        private MenuStrip menuStrip1;
        private ToolStripTextBox toolStripTextBox1;
    }
}