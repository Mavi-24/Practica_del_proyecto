namespace AutomotrizReport
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnAutopartes = new System.Windows.Forms.Button();
            this.btnInAutos = new System.Windows.Forms.Button();
            this.btnFacturas = new System.Windows.Forms.Button();
            this.autopartesDS = new AutomotrizReport.AutopartesDS();
            this.pa_autopartesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paautopartesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pa_autopartesTableAdapter = new AutomotrizReport.AutopartesDSTableAdapters.pa_autopartesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.autopartesDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pa_autopartesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paautopartesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.autopartesDS, "pa_autopartes.descripcion", true));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.pa_autopartesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "AutomotrizReport.AutopartesRepo.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(2, 49);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(697, 675);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // btnAutopartes
            // 
            this.btnAutopartes.Location = new System.Drawing.Point(12, 12);
            this.btnAutopartes.Name = "btnAutopartes";
            this.btnAutopartes.Size = new System.Drawing.Size(101, 23);
            this.btnAutopartes.TabIndex = 1;
            this.btnAutopartes.Text = "Volver al Menu";
            this.btnAutopartes.UseVisualStyleBackColor = true;
            this.btnAutopartes.Click += new System.EventHandler(this.btnAutopartes_Click);
            // 
            // btnInAutos
            // 
            this.btnInAutos.Location = new System.Drawing.Point(154, 12);
            this.btnInAutos.Name = "btnInAutos";
            this.btnInAutos.Size = new System.Drawing.Size(101, 23);
            this.btnInAutos.TabIndex = 2;
            this.btnInAutos.Text = "Informes de Autos";
            this.btnInAutos.UseVisualStyleBackColor = true;
            this.btnInAutos.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnFacturas
            // 
            this.btnFacturas.Location = new System.Drawing.Point(261, 12);
            this.btnFacturas.Name = "btnFacturas";
            this.btnFacturas.Size = new System.Drawing.Size(125, 23);
            this.btnFacturas.TabIndex = 3;
            this.btnFacturas.Text = "Informes de Facturas";
            this.btnFacturas.UseVisualStyleBackColor = true;
            this.btnFacturas.Click += new System.EventHandler(this.btnFacturas_Click);
            // 
            // autopartesDS
            // 
            this.autopartesDS.DataSetName = "AutopartesDS";
            this.autopartesDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pa_autopartesBindingSource
            // 
            this.pa_autopartesBindingSource.DataMember = "pa_autopartes";
            this.pa_autopartesBindingSource.DataSource = this.autopartesDS;
            // 
            // paautopartesBindingSource
            // 
            this.paautopartesBindingSource.DataMember = "pa_autopartes";
            this.paautopartesBindingSource.DataSource = this.autopartesDS;
            // 
            // pa_autopartesTableAdapter
            // 
            this.pa_autopartesTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 724);
            this.Controls.Add(this.btnFacturas);
            this.Controls.Add(this.btnInAutos);
            this.Controls.Add(this.btnAutopartes);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.autopartesDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pa_autopartesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paautopartesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private AutopartesDS autopartesDS;
        private System.Windows.Forms.BindingSource paautopartesBindingSource;
        private AutopartesDSTableAdapters.pa_autopartesTableAdapter pa_autopartesTableAdapter;
        private System.Windows.Forms.BindingSource pa_autopartesBindingSource;
        private System.Windows.Forms.Button btnAutopartes;
        private System.Windows.Forms.Button btnInAutos;
        private System.Windows.Forms.Button btnFacturas;
    }
}

