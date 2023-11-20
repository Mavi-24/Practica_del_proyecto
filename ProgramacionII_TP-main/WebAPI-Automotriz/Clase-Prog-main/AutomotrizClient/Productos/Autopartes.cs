using Libreria.Datos;
using Libreria.Dominio;
using AutomotrizClient.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AutomotrizClient
{
    public partial class Autopartes : Form
    {
        HelperDB data = new HelperDB();
        private Autoparte oAutoparte;
        bool nuevo = true;

        public Autopartes()
        {
            InitializeComponent();
            oAutoparte = new Autoparte();
        }

        private void Autopartes_Load(object sender, EventArgs e)
        {
            cargarcomboModelosAsync();
            cargarcomboVehiculosAsync();
            txtBuscar.Hide();
            btnBuscar.Hide();
            lblCodigo.Hide();
            lblNro.Text = "Autoparte N°: " + data.ObtenerProxProducto();
        }
        private async Task ModificarAutoparteAsync()
        {
            oAutoparte.Codigo = Convert.ToInt32(txtBuscar.Text);
            oAutoparte.Descripcion = txtDescripcion.Text;
            oAutoparte.TipoVehiculo = cboVehiculos.SelectedIndex + 1;
            oAutoparte.Modelo = cboModelos.SelectedIndex + 1;
            oAutoparte.Precio = Convert.ToDouble(txtPre_unitario.Text);

            string bodyContent = JsonConvert.SerializeObject(oAutoparte);

            string url = "http://localhost:5046/modificar_autoparte";
            var res = await ClientSingleton.GetInstance().PutAsync(url, bodyContent);

            if (res.Equals("true"))
            {
                MessageBox.Show("Se ha registrado el autoparte correctamente", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("No se pudo registrar el autoparte", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task InsertarAutoparteAsync()
        {
            oAutoparte.Descripcion = txtDescripcion.Text;
            oAutoparte.TipoVehiculo = cboVehiculos.SelectedIndex + 1;
            oAutoparte.Modelo = cboModelos.SelectedIndex + 1;
            oAutoparte.Precio = Convert.ToDouble(txtPre_unitario.Text);

            string bodyContent = JsonConvert.SerializeObject(oAutoparte);

            string url = "http://localhost:5046/autoparte";
            var res = await ClientSingleton.GetInstance().PostAsync(url, bodyContent);

            if (res.Equals("true"))
            {
                MessageBox.Show("Autoparte registrada", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("No se pudo registrar el autoparte", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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


        private async void cargarcomboModelosAsync()
        {
            string url = "http://localhost:5046/modelos";
            var res = await ClientSingleton.GetInstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<Modelo>>(res);
            cboModelos.DataSource = lst;
            cboModelos.ValueMember = "Codigo";
            cboModelos.DisplayMember = "Descripcion";
            cboModelos.SelectedIndex = -1;

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                int nroAutoparte = Convert.ToInt32(txtBuscar.Text);
                txtDescripcion.Text = data.ConsultarAutoparte(nroAutoparte, "DESCRIPCION").ToString();
                if (txtDescripcion.Text == "No se encontro")
                {
                    txtPre_unitario.Text = "";
                    cboVehiculos.SelectedIndex = -1;
                    cboModelos.SelectedIndex = -1;
                }
                else
                {
                    txtPre_unitario.Text = data.ConsultarAutoparte(nroAutoparte, "PRECIO").ToString();
                    cboVehiculos.Text = data.ConsultarAutoparte(nroAutoparte, "VEHICULO").ToString();
                    cboModelos.Text = data.ConsultarAutoparte(nroAutoparte, "MODELO").ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Debe ingresar un numero valido!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Limpiar();
            if (nuevo == true)
            {
                txtBuscar.Show();
                btnBuscar.Show();
                lblCodigo.Show();
                btnNuevo.Text = "Nuevo";
                gbpMain.Text = "Editar Autoparte";
                nuevo = false;
            }
            else
            {
                txtBuscar.Hide();
                btnBuscar.Hide();
                lblCodigo.Hide();
                btnNuevo.Text = "Consultar";
                gbpMain.Text = "Nueva Autoparte";
                nuevo = true;
            }
        }

        private void Limpiar()
        {
            txtBuscar.Text = "";
            txtDescripcion.Text = "";
            txtPre_unitario.Text = "";
            cboModelos.SelectedIndex = -1;
            cboVehiculos.SelectedIndex = -1;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (txtDescripcion.Text == "")
            {
                MessageBox.Show("Debe ingresar una descripcion!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (cboVehiculos.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un tipo de vehiculo!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (cboModelos.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un modelo de vehiculo!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (double.TryParse(txtPre_unitario.Text, out _) == false)
            {
                MessageBox.Show("Debe ingresar un precio valido!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if(txtDescripcion.Text == "No se encontro")
            {
                MessageBox.Show("El modelo no existe!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (nuevo == true)
            {
                InsertarAutoparteAsync();
            }
            else
            {
                ModificarAutoparteAsync();
            }
        }
    }
}
