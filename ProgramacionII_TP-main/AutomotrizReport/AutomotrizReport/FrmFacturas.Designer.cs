namespace AutomotrizReport
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnAutos = new System.Windows.Forms.Button();
            this.btnAutopartes = new System.Windows.Forms.Button();
            this.inforFacturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.autopartesDS = new AutomotrizReport.AutopartesDS();
            this.inforFacturaTableAdapter = new AutomotrizReport.AutopartesDSTableAdapters.InforFacturaTableAdapter();
            this.RepoFacturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repoFacturaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.repoFacturaTableAdapter = new AutomotrizReport.AutopartesDSTableAdapters.RepoFacturaTableAdapter();
            this.repoFacturaBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.inforFacturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autopartesDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepoFacturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoFacturaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoFacturaBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.repoFacturaBindingSource2;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "AutomotrizReport.FacturaRepo.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(-2, 82);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(697, 558);
            this.reportViewer1.TabIndex = 0;
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(13, 13);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(75, 23);
            this.btnMenu.TabIndex = 1;
            this.btnMenu.Text = "Volver al Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            // 
            // btnAutos
            // 
            this.btnAutos.Location = new System.Drawing.Point(193, 12);
            this.btnAutos.Name = "btnAutos";
            this.btnAutos.Size = new System.Drawing.Size(111, 23);
            this.btnAutos.TabIndex = 2;
            this.btnAutos.Text = "Informes de Autos";
            this.btnAutos.UseVisualStyleBackColor = true;
            this.btnAutos.Click += new System.EventHandler(this.btnAutos_Click);
            // 
            // btnAutopartes
            // 
            this.btnAutopartes.Location = new System.Drawing.Point(310, 13);
            this.btnAutopartes.Name = "btnAutopartes";
            this.btnAutopartes.Size = new System.Drawing.Size(133, 23);
            this.btnAutopartes.TabIndex = 3;
            this.btnAutopartes.Text = "Informes de Autopartes";
            this.btnAutopartes.UseVisualStyleBackColor = true;
            this.btnAutopartes.Click += new System.EventHandler(this.btnAutopartes_Click);
            // 
            // inforFacturaBindingSource
            // 
            this.inforFacturaBindingSource.DataMember = "InforFactura";
            this.inforFacturaBindingSource.DataSource = this.autopartesDS;
            // 
            // autopartesDS
            // 
            this.autopartesDS.DataSetName = "AutopartesDS";
            this.autopartesDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inforFacturaTableAdapter
            // 
            this.inforFacturaTableAdapter.ClearBeforeFill = true;
            // 
            // RepoFacturaBindingSource
            // 
            this.RepoFacturaBindingSource.DataMember = "RepoFactura";
            this.RepoFacturaBindingSource.DataSource = this.autopartesDS;
            // 
            // repoFacturaBindingSource1
            // 
            this.repoFacturaBindingSource1.DataMember = "RepoFactura";
            this.repoFacturaBindingSource1.DataSource = this.autopartesDS;
            // 
            // repoFacturaTableAdapter
            // 
            this.repoFacturaTableAdapter.ClearBeforeFill = true;
            // 
            // repoFacturaBindingSource2
            // 
            this.repoFacturaBindingSource2.DataMember = "RepoFactura";
            this.repoFacturaBindingSource2.DataSource = this.autopartesDS;
            // 
            // FrmFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 652);
            this.Controls.Add(this.btnAutopartes);
            this.Controls.Add(this.btnAutos);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmFacturas";
            this.Text = "FrmFacturas";
            this.Load += new System.EventHandler(this.FrmFacturas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inforFacturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autopartesDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepoFacturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoFacturaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoFacturaBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private AutopartesDS autopartesDS;
        private System.Windows.Forms.BindingSource inforFacturaBindingSource;
        private AutopartesDSTableAdapters.InforFacturaTableAdapter inforFacturaTableAdapter;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnAutos;
        private System.Windows.Forms.Button btnAutopartes;
        private System.Windows.Forms.BindingSource RepoFacturaBindingSource;
        private System.Windows.Forms.BindingSource repoFacturaBindingSource1;
        private AutopartesDSTableAdapters.RepoFacturaTableAdapter repoFacturaTableAdapter;
        private System.Windows.Forms.BindingSource repoFacturaBindingSource2;
    }
}