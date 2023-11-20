using AutomotrizClient.Http;
using Libreria.Datos;
using Libreria.Dominio;
using Newtonsoft.Json;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace AutomotrizClient
{
    public partial class FrmFacturas : Form
    {
        private Factura oFactura;

        public FrmFacturas()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            oFactura = new Factura();
        }

        #region AGREGADOS ESTETICOS
        private const int cGrip = 16;      // Grip size
        private const int cCaption = 32;   // Caption bar height

        protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle rc = new Rectangle(this.ClientSize.Width - cGrip, this.ClientSize.Height - cGrip, cGrip, cGrip);
            ControlPaint.DrawSizeGrip(e.Graphics, this.BackColor, rc);
            rc = new Rectangle(0, 0, this.ClientSize.Width, cCaption);
            e.Graphics.FillRectangle(Brushes.White, rc);
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {  // Trap WM_NCHITTEST
                Point pos = new Point(m.LParam.ToInt32());
                pos = this.PointToClient(pos);
                if (pos.Y < cCaption)
                {
                    m.Result = (IntPtr)2;  // HTCAPTION
                    return;
                }
                if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr)17; // HTBOTTOMRIGHT
                    return;
                }
            }
            base.WndProc(ref m);
        }
        #endregion

        private void Frm_Facturas_Load_1(object sender, EventArgs e)
        {
            ProximaFactura();//OK
            CargarEmpleados();//OK
            CargarClientes();//OK
            CargarPlanes();//OK

            txtFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");//OK

            cboProductos.Enabled = false;
            txtNroFactura.Hide();
            btnBuscar.Hide();
            gbBorrar.Hide();
            DesactivarTodo();
        }

        #region SOPORTE WEBAPI
        private async void ProximaFactura()
        {
            string url = "http://localhost:5046/proxima_factura";
            var res = await ClientSingleton.GetInstance().GetAsync(url);
            var prox = JsonConvert.DeserializeObject<int>(res);
            lblNroFactura.Text = "Nº Factura:   " + prox.ToString();
        }

        private async void CargarAutopartes()
        {
            string url = "http://localhost:5046/autopartes";
            var res = await ClientSingleton.GetInstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<Producto>>(res);
            cboProductos.DataSource = lst;
            cboProductos.ValueMember = "CodProducto";
            cboProductos.DisplayMember = "Descripcion";
            cboProductos.SelectedIndex = -1;
        }

        private async void CargarAutomoviles()
        {
            string url = "http://localhost:5046/automoviles";
            var res = await ClientSingleton.GetInstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<Producto>>(res);
            cboProductos.DataSource = lst;
            cboProductos.ValueMember = "CodProducto";
            cboProductos.DisplayMember = "Descripcion";
            cboProductos.SelectedIndex = -1;
        }

        private async void CargarPlanes()
        {
            string url = "http://localhost:5046/autoplanes";
            var res = await ClientSingleton.GetInstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<Autoplan>>(res);
            cboPlan.DataSource = lst;
            cboPlan.ValueMember = "CodPlan";
            cboPlan.DisplayMember = "NomPlan";
            cboPlan.SelectedIndex = -1;
        }

        private async void CargarEmpleados()
        {
            string url = "http://localhost:5046/empleados";
            var res = await ClientSingleton.GetInstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<Empleado>>(res);
            cboEmpleado.DataSource = lst;
            cboEmpleado.ValueMember = "Legajo";
            cboEmpleado.DisplayMember = "Nombre";
            cboEmpleado.SelectedIndex = -1;
        }

        public async void CargarClientes()
        {
            string url = "http://localhost:5046/clientes";
            var res = await ClientSingleton.GetInstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<Cliente>>(res);
            cboClientes.DataSource = lst;
            cboClientes.ValueMember = "NroFactura";
            cboClientes.DisplayMember = "Nombre";
            cboClientes.SelectedIndex = -1;
        }

        #endregion

        private void LimpiarTodo()
        {
            lblNroFactura.Text = "Nº Factura:   ";
            cboEmpleado.SelectedIndex = -1;
            cboClientes.SelectedIndex = -1;
            cboPlan.SelectedIndex = -1;
            rbAutomovil.Checked = false;
            rbAutoparte.Checked = false;
            cboProductos.SelectedIndex = -1;
            txtPrecio.Text = String.Empty;
            txtCantidad.Text = String.Empty;
            txtFecha.Text = String.Empty;
            dgvDetalles1.Rows.Clear();
            txtFinal.Text = String.Empty;
        }

        private void DesactivarTodo()
        {
            cboEmpleado.Enabled = false;
            cboClientes.Enabled = false;
            cboPlan.Enabled = false;
            gbCargaProducto.Enabled = false;
            dgvDetalles1.Enabled = false;
            btnAceptar.Enabled = false;
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarTodo();
            txtFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            ProximaFactura();
            DesactivarTodo();
            cboEmpleado.Enabled = true;
            btnAceptar.Enabled = true;
            txtNroFactura.Hide();
            btnBuscar.Hide();
            gbBorrar.Hide();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        //AGREGAR UN DETALLE AL DATAGRIDVIEW
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            #region VALIDACIONES
            if (cboProductos.Text.Equals(String.Empty))
            {
                MessageBox.Show("Debe seleccionar un PRODUCTO!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (txtCantidad.Text == "" || !int.TryParse(txtCantidad.Text, out _))
            {
                MessageBox.Show("Debe ingresar una cantidad válida!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            foreach (DataGridViewRow row in dgvDetalles1.Rows)
            {
                if (row.Cells["colProd"].Value.ToString().Equals(cboProductos.Text))
                {
                    MessageBox.Show("PRODUCTO: " + cboProductos.Text + " ya se encuentra como detalle!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            #endregion

            DetalleFactura det = new DetalleFactura();
            DataGridViewRow fila = new DataGridViewRow();
            fila.CreateCells(dgvDetalles1);

            det.CodProducto = (int)cboProductos.SelectedValue;
            det.Cantidad = Convert.ToInt32(txtCantidad.Text);
            det.Precio = Convert.ToDouble(txtPrecio.Text);

            fila.Cells[0].Value = det.CodProducto.ToString();
            fila.Cells[1].Value = cboProductos.Text;
            fila.Cells[2].Value = det.Cantidad.ToString();
            fila.Cells[3].Value = det.Precio.ToString();

            dgvDetalles1.Rows.Add(fila);

            oFactura.AgregarDetalle(det);
            CalcularTotal();
        }

        #region CONFIRMAR NUEVA FACTURA
        private async Task GuardarFacturaAsync()
        {
            //datos de la factura
            if (rbAutoparte.Checked)
            {
                oFactura.CodPlan = 0;
            }
            oFactura.CodEmpleado = cboEmpleado.SelectedIndex + 1;
            oFactura.NomCliente = cboClientes.Text;
            oFactura.CodPlan = cboPlan.SelectedIndex + 1;
            oFactura.CodTipoCliente = 1;

            string bodyContent = JsonConvert.SerializeObject(oFactura);

            string url = "http://localhost:5046/insertar_factura";
            var res = await ClientSingleton.GetInstance().PostAsync(url, bodyContent);

            if (res.Equals("true"))
            {
                MessageBox.Show("Factura registrada", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("No se pudo registrar la factura", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (cboEmpleado.SelectedIndex == -1)
            {
                MessageBox.Show("Debe ingresar un empleado!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (cboClientes.SelectedIndex == -1)
            {
                MessageBox.Show("Debe ingresar un cliente!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (dgvDetalles1.Rows.Count == 0)
            {
                MessageBox.Show("Debe ingresar al menos detalle!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            GuardarFacturaAsync();
        }
        #endregion

        //ACTUALIZAR TOTAL DETALLES
        private void CalcularTotal()
        {
            double total = oFactura.CalcularTotal();
            txtFinal.Text = total.ToString();
        }

        //BORRAR UN DETALLE DEL DATAGRIDVIEW
        private void dgvDetalles_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDetalles1.CurrentCell.ColumnIndex == 4)
            {
                oFactura.QuitarDetalle(dgvDetalles1.CurrentRow.Index);
                dgvDetalles1.Rows.Remove(dgvDetalles1.CurrentRow);
                CalcularTotal();
            }
        }

        //BUSCAR UNA FACTURA
        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            txtNroFactura.Show();
            btnBuscar.Show();
            LimpiarTodo();
            DesactivarTodo();
            gbBorrar.Hide();
            dgvDetalles1.Columns[4].Visible = false;
            //DataGridViewBand band = dgvDetalles1.Rows[];
            //band.Visible = false;
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            LimpiarTodo();

            string url = $"http://localhost:5046/consultar_factura?nroFactura={txtNroFactura.Text}";
            var res = await ClientSingleton.GetInstance().GetAsync(url);
            var aux = JsonConvert.DeserializeObject<Factura>(res);

            lblNroFactura.Text = "Nº Factura:   " + aux.CodFactura.ToString();
            cboEmpleado.SelectedValue = aux.CodEmpleado;
            cboClientes.Text = aux.NomCliente;
            cboPlan.SelectedValue = aux.CodPlan;
            txtFecha.Text = aux.Fecha.ToString("dd/MM/yyyy");

            foreach (DetalleFactura det in aux.Detalles)
            {
                DataGridViewRow fila = new DataGridViewRow();
                fila.CreateCells(dgvDetalles1);

                fila.Cells[0].Value = det.CodProducto.ToString();
                fila.Cells[1].Value = det.Descripcion;
                fila.Cells[2].Value = det.Cantidad.ToString();
                fila.Cells[3].Value = det.Precio.ToString();

                dgvDetalles1.Rows.Add(fila);
            }

            txtNroFactura.Text = String.Empty;
            txtNroFactura.Hide();
            btnBuscar.Hide();
        }

        #region CONTROL RADIO BUTTONS
        private void rbAutomovil_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAutomovil.Checked)
            {
                cboPlan.Enabled = true;
                cboPlan.SelectedIndex = -1;
                cboProductos.Enabled = true;
                CargarAutomoviles();
            }
        }

        private void rbAutoparte_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAutoparte.Checked)
            {
                cboProductos.Enabled = true;
                cboPlan.Enabled = false;
                cboPlan.SelectedIndex = -1;
                CargarAutopartes();
            }
        }
        #endregion

        //BORRAR UNA FACTURA
        private async void btnBorrarFactura_Click(object sender, EventArgs e)
        {
            string url = $"http://localhost:5046/borrar_facturas?cod={txtBorrarFact.Text}";
            var res = await ClientSingleton.GetInstance().DeleteAsync(url);
            //var aux = JsonConvert.DeserializeObject<int>(res);

            if (res.Equals("true"))
            {
                MessageBox.Show("La factura se borro", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("La factura no existe", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboEmpleado.SelectedIndex != -1)
            {
                cboClientes.Enabled = true;
            }
        }

        private void cboClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboClientes.SelectedIndex != -1)
            {
                gbCargaProducto.Enabled = true;
                dgvDetalles1.Enabled = true;
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            DesactivarTodo();
            gbBorrar.Show();
            txtNroFactura.Hide();
            btnBuscar.Hide();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarTodo();
            DesactivarTodo();
            txtNroFactura.Hide();
            btnBuscar.Hide();
            gbBorrar.Hide();
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show(" Solo Numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show(" Solo Numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}