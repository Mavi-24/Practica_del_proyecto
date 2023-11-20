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
    public partial class frmAutomoviles : Form
    {
        public frmAutomoviles()
        {
            InitializeComponent();
        }

        private void frmAutomoviles_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
