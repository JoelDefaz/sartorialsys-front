using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace sartorialsys_front
{
    public partial class frmLogin : Form
    {
        private static readonly HttpClient client = new HttpClient();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void btnAcceder_Click(object sender, EventArgs e)
        {
            string token = await GetJwtTokenAsync();
            // Validar si el token es válido antes de abrir la ventana
            if (!string.IsNullOrEmpty(token))
            {
                MessageBox.Show("Bienvenido " + txtUsuario.Text, "Autenticación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error de autenticación. No se pudo obtener el token.");
            }
        }

        private async Task<string> GetJwtTokenAsync()
        {
            var requestData = new
            {
                username = txtUsuario.Text,
                password = txtPassword.Text
            };

            string json = JsonConvert.SerializeObject(requestData);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await client.PostAsync("http://localhost:8000/api/token/", content);

            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsStringAsync();
                var tokenData = JsonConvert.DeserializeObject<dynamic>(result);
                return tokenData.access.ToString();
            }
            else
            {
                MessageBox.Show("Credenciales Incorrectas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
