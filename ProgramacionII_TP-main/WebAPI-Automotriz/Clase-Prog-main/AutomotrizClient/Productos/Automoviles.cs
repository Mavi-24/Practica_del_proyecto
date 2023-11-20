using AutomotrizClient.Http;
using Libreria.Datos;
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
    public partial class Automoviles : Form
    {

        HelperDB data = new HelperDB();
        private Automovil oAutomovil;
        bool nuevo = true;

        public Automoviles()
        {
            InitializeComponent();
            oAutomovil = new Automovil();
        }

        private async void cargarcomboVehiculosAsync()
        {
            string url = "http://localhost:5046/tipos_vehiculos";
            var res = await ClientSingleton.GetInstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<TipoVehiculo>>(res);
            cboVehiculos.DataSource = lst;
            cboVehiculos.ValueMember = "Codigo";
            cboVehiculos.DisplayMember = "Descripcion";
            cboVehiculos.SelectedIndex = -1;
        }

        private void Automoviles_Load(object sender, EventArgs e)
        {
            cargarcomboVehiculosAsync();
            txtBuscar.Hide();
            btnBuscar.Hide();
            lblCodigo.Hide();
            lblNro.Text = "Automovil N°:" + data.ObtenerProxProducto();
        }

        private async Task InsertarAutomovilAsync()
        {
            oAutomovil.Modelo = txtModelo.Text;
            oAutomovil.TipoVehiculo = cboVehiculos.SelectedIndex + 1;
            oAutomovil.Precio = Convert.ToDouble(txtPre_unitario.Text);

            string bodyContent = JsonConvert.SerializeObject(oAutomovil);

            string url = "http://localhost:5046/automovil";
            var res = await ClientSingleton.GetInstance().PostAsync(url, bodyContent);

            if (res.Equals("true"))
            {
                MessageBox.Show("Automovil Registrado", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("No se pudo registrar el Automovil", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task ModificarAutomovilAsync()
        {
            oAutomovil.Codigo = Convert.ToInt32(txtBuscar.Text);
            oAutomovil.Modelo = txtModelo.Text;
            oAutomovil.TipoVehiculo = cboVehiculos.SelectedIndex + 1;
            oAutomovil.Precio = Convert.ToDouble(txtPre_unitario.Text);

            string bodyContent = JsonConvert.SerializeObject(oAutomovil);

            string url = "http://localhost:5046/modificar_automovil";
            var res = await ClientSingleton.GetInstance().PutAsync(url, bodyContent);

            if (res.Equals("true"))
            {
                MessageBox.Show("Automovil Registrado", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("No se pudo registrar el Automovil", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (cboVehiculos.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un tipo de vehiculo!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtModelo.Text == "")
            {
                MessageBox.Show("Debe seleccionar un modelo de vehiculo!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (double.TryParse(txtPre_unitario.Text, out _) == false)
            {
                MessageBox.Show("Debe ingresar un precio valido!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (txtModelo.Text == "No se encontro")
            {
                MessageBox.Show("El modelo no existe!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (nuevo == true)
            {
                InsertarAutomovilAsync();
            }
            else
            {
                ModificarAutomovilAsync();
            }
        }

        private void Limpiar()
        {
            txtBuscar.Text = "";
            txtPre_unitario.Text = "";
            cboVehiculos.SelectedIndex = -1;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
            if (nuevo == true)
            {
                txtBuscar.Show();
                btnBuscar.Show();
                lblCodigo.Show();
                btnNuevo.Text = "Nuevo";
                gpbMain.Text = "Editar Automovil";
                txtModelo.Enabled = false;
                nuevo = false;
            }
            else
            {
                txtBuscar.Hide();
                btnBuscar.Hide();
                lblCodigo.Hide();
                btnNuevo.Text = "Editar";
                gpbMain.Text = "Nueva Automovil";
                txtModelo.Enabled = true;
                nuevo = true;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                int nroAutomovil = Convert.ToInt32(txtBuscar.Text);
                txtModelo.Text = data.ConsultarAutomovil(nroAutomovil, "MODELO").ToString();
                if (txtModelo.Text == "No se encontro")
                {
                    txtPre_unitario.Text = "";
                    cboVehiculos.SelectedIndex = -1;
                }
                else
                {
                    txtPre_unitario.Text = data.ConsultarAutoparte(nroAutomovil, "PRECIO").ToString();
                    cboVehiculos.Text = data.ConsultarAutoparte(nroAutomovil, "VEHICULO").ToString();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
                //MessageBox.Show("Debe ingresar un numero valido!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void gpbMain_Enter(object sender, EventArgs e)
        {

        }

        private void cboVehiculos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
