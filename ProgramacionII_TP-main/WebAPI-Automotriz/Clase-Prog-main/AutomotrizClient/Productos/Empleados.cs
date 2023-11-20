using AutomotrizClient.Http;
using Libreria.Dominio;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomotrizClient.Productos
{
    public partial class Empleados : Form
    {
        public Empleados()
        {
            InitializeComponent();
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Empleados_Load(object sender, EventArgs e)
        {
            cargarcomboTipoEmpleadosAsync();
        }

        private async void cargarcomboTipoEmpleadosAsync()
        {
            string url = "http://localhost:5046/tipos_empleado";
            var res = await ClientSingleton.GetInstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<TipoEmpleado>>(res);
            cboEmpleado.DataSource = lst;
            cboEmpleado.ValueMember = "Codigo";
            cboEmpleado.DisplayMember = "Descripcion";
            cboEmpleado.SelectedIndex = -1;
        }

        private async Task InsertarEmpleadoAsync()
        {
            Empleado oEmpleado = new Empleado();
            oEmpleado.Nombre = txtNombre.Text;
            oEmpleado.Tipo_empleado = cboEmpleado.SelectedIndex + 1;

            string bodyContent = JsonConvert.SerializeObject(oEmpleado);

            string url = "http://localhost:5046/insert_empleado";
            var res = await ClientSingleton.GetInstance().PostAsync(url, bodyContent);

            if (res.Equals("true"))
            {
                MessageBox.Show("Empleado registrado", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
            else
            {
                MessageBox.Show("No se pudo registrar al empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Limpiar()
        {
            txtNombre.Text = "";
            cboEmpleado.SelectedIndex = -1;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cboEmpleado.SelectedIndex == -1)
            {
                MessageBox.Show("Debe ingresar un Tipo de empleado!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (!string.IsNullOrEmpty(txtNombre.Text))
            {
                // Verificar que solo se ingresen letras
                if (txtNombre.Text.All(char.IsLetter))
                {
                    // Todo está bien, solo contiene letras
                }
                else
                {
                    MessageBox.Show("El Nombre solo puede contener letras.", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            else
            {
                MessageBox.Show("El Nombre no puede estar vacío.", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            InsertarEmpleadoAsync();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
