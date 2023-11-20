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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'autopartesDS.pa_autopartes' Puede moverla o quitarla según sea necesario.
            this.pa_autopartesTableAdapter.Fill(this.autopartesDS.pa_autopartes);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnAutopartes_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 au = new Form2();
            au.ShowDialog();
        }

        private void btnFacturas_Click(object sender, EventArgs e)
        {
            FrmFacturas fa = new FrmFacturas();
            fa.ShowDialog();
        }
    }
}
