using AutomotrizClient;
using AutomotrizClient.Http;
using Libreria.Datos;
using Libreria.Dominio;
using Newtonsoft.Json;

namespace AutomotrizClient
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void btnOk_Click(object sender, EventArgs e)
        {
            string url = $"http://localhost:5046/login?user={txtUsuario.Text}&pass={txtContraseña.Text}";
            var res = await ClientSingleton.GetInstance().GetAsync(url);
            var aux = JsonConvert.DeserializeObject<int>(res);

            if (aux == 1)
            {
                Menu menu = new Menu();
                this.Hide();
                menu.ShowDialog();
            }
            else if (aux == 0)
            {
                MessageBox.Show("¡¡Usuario o contraseña incorrecta!!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}