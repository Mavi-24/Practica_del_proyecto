using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WfrAutopartes
{
    public partial class frmAutopartes : Form
    {
        public frmAutopartes()
        {
            InitializeComponent();
        }

        private void frmAutopartes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.pa_autopartes' Puede moverla o quitarla según sea necesario.
            this.pa_autopartesTableAdapter.Fill(this.dataSet1.pa_autopartes);

            this.reportViewer1.RefreshReport();
        }
    }
}
