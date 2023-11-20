namespace AutomotrizReport
{
    partial class Form2
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
            this.paautomovilesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.autopartesDS = new AutomotrizReport.AutopartesDS();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.pa_automovilesTableAdapter = new AutomotrizReport.AutopartesDSTableAdapters.pa_automovilesTableAdapter();
            this.btnReMenu = new System.Windows.Forms.Button();
            this.btnAutopartes = new System.Windows.Forms.Button();
            this.btnFacturas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.paautomovilesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autopartesDS)).BeginInit();
            this.SuspendLayout();
            // 
            // paautomovilesBindingSource
            // 
            this.paautomovilesBindingSource.DataMember = "pa_automoviles";
            this.paautomovilesBindingSource.DataSource = this.autopartesDS;
            // 
            // autopartesDS
            // 
            this.autopartesDS.DataSetName = "AutopartesDS";
            this.autopartesDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "AutosDS";
            reportDataSource1.Value = this.paautomovilesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "AutomotrizReport.AutosInfo.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 56);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(726, 599);
            this.reportViewer1.TabIndex = 0;
            // 
            // pa_automovilesTableAdapter
            // 
            this.pa_automovilesTableAdapter.ClearBeforeFill = true;
            // 
            // btnReMenu
            // 
            this.btnReMenu.Location = new System.Drawing.Point(13, 13);
            this.btnReMenu.Name = "btnReMenu";
            this.btnReMenu.Size = new System.Drawing.Size(98, 23);
            this.btnReMenu.TabIndex = 1;
            this.btnReMenu.Text = "Volver al Menu";
            this.btnReMenu.UseVisualStyleBackColor = true;
            // 
            // btnAutopartes
            // 
            this.btnAutopartes.Location = new System.Drawing.Point(201, 13);
            this.btnAutopartes.Name = "btnAutopartes";
            this.btnAutopartes.Size = new System.Drawing.Size(124, 23);
            this.btnAutopartes.TabIndex = 2;
            this.btnAutopartes.Text = "Informe de Autopartes";
            this.btnAutopartes.UseVisualStyleBackColor = true;
            this.btnAutopartes.Click += new System.EventHandler(this.btnAutopartes_Click);
            // 
            // btnFacturas
            // 
            this.btnFacturas.Location = new System.Drawing.Point(331, 13);
            this.btnFacturas.Name = "btnFacturas";
            this.btnFacturas.Size = new System.Drawing.Size(116, 23);
            this.btnFacturas.TabIndex = 3;
            this.btnFacturas.Text = "Informe de Facturas";
            this.btnFacturas.UseVisualStyleBackColor = true;
            this.btnFacturas.Click += new System.EventHandler(this.btnFacturas_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 574);
            this.Controls.Add(this.btnFacturas);
            this.Controls.Add(this.btnAutopartes);
            this.Controls.Add(this.btnReMenu);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form2";
            this.Text = "Auto";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.paautomovilesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autopartesDS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private AutopartesDS autopartesDS;
        private System.Windows.Forms.BindingSource paautomovilesBindingSource;
        private AutopartesDSTableAdapters.pa_automovilesTableAdapter pa_automovilesTableAdapter;
        private System.Windows.Forms.Button btnReMenu;
        private System.Windows.Forms.Button btnAutopartes;
        private System.Windows.Forms.Button btnFacturas;
    }
}