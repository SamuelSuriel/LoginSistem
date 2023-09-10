using LoginSistem.Clases;
using Microsoft.Data.SqlClient;

namespace LoginSistem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            var esValido = false;
            var usuarioValido = txtUsuario.Text;
            var passwordValido = txtPassword.Text;


            if (usuarioValido != string.Empty && passwordValido != string.Empty)
            {
                SqlConnection connetionString = new SqlConnection(@"server=LEVHDLL; Database=Ventas; integrated security =True; TrustServerCertificate=True");
                connetionString.Open();

                //int clave = int.Parse(passwordValido);
                string query = "SELECT Nombre, Clave FROM Usuarios WHERE Clave = " + passwordValido;

                SqlCommand comando = new SqlCommand(query, connetionString);
                SqlDataReader registro = comando.ExecuteReader();

                if (registro.Read())
                {
                    Usuarios usuario = new Usuarios();

                    usuario.Nombre = (string)registro["Nombre"];
                    usuario.Clave = (string?)registro["Clave"];

                    if (usuarioValido == usuario.Nombre && passwordValido == usuario.Clave)
                        esValido = true;

                    if (esValido)
                    {
                        MessageBox.Show("Usuario y contraseña son correctos!");
                        this.Hide();
                        MenuPrincipal menuPrincipal = new MenuPrincipal();

                        menuPrincipal.txtUsuarioMenu.Text = usuarioValido;
                        menuPrincipal.txtPasswordMenu.Text = passwordValido;

                        menuPrincipal.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Usuario y contraseña no son correctos!");

                    }
                }
                else
                {
                    MessageBox.Show("Ups, ocurrio un error inesperado!");
                }
                connetionString.Close();
            }
            else
            {
                   MessageBox.Show("Ingrese los datos requeridos!");
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}