using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomotrizReport
{
    public partial class FrmFacturas : Form
    {
        public FrmFacturas()
        {
            InitializeComponent();
        }

        private void FrmFacturas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'autopartesDS.RepoFactura' Puede moverla o quitarla según sea necesario.
            this.repoFacturaTableAdapter.Fill(this.autopartesDS.RepoFactura);
            // TODO: esta línea de código carga datos en la tabla 'autopartesDS.InforFactura' Puede moverla o quitarla según sea necesario.
            this.inforFacturaTableAdapter.Fill(this.autopartesDS.InforFactura);

            this.reportViewer1.RefreshReport();
        }

        private void btnAutos_Click(object sender, EventArgs e)
        {
            Form2 au = new Form2();
            au.ShowDialog();

        }

        private void btnAutopartes_Click(object sender, EventArgs e)
        {
            Form1 pa = new Form1();
            pa.ShowDialog();
        }
    }
}
