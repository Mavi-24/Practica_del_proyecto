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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'autopartesDS.pa_automoviles' Puede moverla o quitarla según sea necesario.
            this.pa_automovilesTableAdapter.Fill(this.autopartesDS.pa_automoviles);

            this.reportViewer1.RefreshReport();
        }

        private void btnAutopartes_Click(object sender, EventArgs e)
        {
            Form1 pa = new Form1();
            pa.ShowDialog();
        }

        private void btnFacturas_Click(object sender, EventArgs e)
        {
            FrmFacturas fa = new FrmFacturas();
            fa.ShowDialog();
        }
    }
}
