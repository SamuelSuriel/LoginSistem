using LoginSistem.Clases;
using LoginSistem.Forms;
using Microsoft.Data.SqlClient;

namespace LoginSistem
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void txtUsuarioMenu_TextChanged(object sender, EventArgs e)
        {
            txtUsuarioMenu.Text = txtUsuarioMenu.Text.Trim();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ComboBoxForm comboBoxForm = new ComboBoxForm();
            comboBoxForm.ShowDialog();
        }

        private void btnEditarUsuario_Click(object sender, EventArgs e)
        {
            this.Hide();

            var usuarioClave = txtPasswordMenu.Text;
            //Abrir el modal
            mdlEditarUsuario mdlEditarUsuario = new mdlEditarUsuario();
            mdlEditarUsuario.ShowDialog();

            Usuarios usuario = new Usuarios();

            //var usuarioID = usuario.UsuarioID;

            //Abrir coneccion a BD
            SqlConnection connetionString = new SqlConnection(@"server=LEVHDLL; Database=Ventas; integrated security =True; TrustServerCertificate=True");
            connetionString.Open();
            string query = "SELECT UsuarioID, Nombre, Clave, IdPerfil FROM Usuarios WHERE Clave = " + usuarioClave;

            SqlCommand comando = new SqlCommand(query, connetionString);
            SqlDataReader registro = comando.ExecuteReader();

            if (registro.Read())
            {
                usuario.UsuarioID = (int)registro["UsuarioID"];
                usuario.Nombre = (string)registro["Nombre"];
                usuario.Clave = (string?)registro["Clave"];
                usuario.IdPerfil = (int)registro["IdPerfil"];
               
                string perfil = "";
                int idPerfil = (int)usuario.IdPerfil;
                if (idPerfil == 1)
                {
                    perfil = "Administrador";
                }
                else if (idPerfil == 2)
                {
                    perfil = "Cajero";
                }
                else if (idPerfil == 3)
                {
                    perfil = "Vendedor";
                }

                mdlEditarUsuario.txtEditUsuarioNombre.Text = usuario.Nombre;
                mdlEditarUsuario.txtEditUsuarioClave.PlaceholderText = usuario.Clave;
                mdlEditarUsuario.cbPerfiles.Text = perfil;

                connetionString.Close();
            }
            {
                MessageBox.Show("Ups, ocurrio un error inesperado!");
            }
        }
           
    }
}
