using LoginSistem.Clases;
using LoginSistem.Forms;
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

            //validamos si los datos son correctos
            if (usuarioValido != string.Empty && passwordValido != string.Empty)
            {
                SqlConnection connetionString = new SqlConnection(@"server=LEVHDLL; Database=Ventas; integrated security =True; TrustServerCertificate=True");
                connetionString.Open();

                //Query que trae los datos desde la base de datos
                string query = "SELECT u.UsuarioID, u.Nombre, u.Clave, u.IdPerfil, p.Perfil FROM Usuarios u INNER JOIN Perfiles p on u.IdPerfil = p.IdPerfil WHERE Clave = " + passwordValido;

                SqlCommand comando = new SqlCommand(query, connetionString);
                SqlDataReader registro = comando.ExecuteReader();

                if (registro.Read())
                {
                    Usuarios usuario = new Usuarios();
                    usuario.UsuarioID = (int)registro["UsuarioID"];
                    usuario.Nombre = (string)registro["Nombre"];
                    usuario.Clave = (string)registro["Clave"];
                    usuario.IdPerfil = (int)registro["IdPerfil"];
                    usuario.Perfil = (string)registro["Perfil"];

                    if (usuarioValido == usuario.Nombre && passwordValido == usuario.Clave)
                        esValido = true;

                    if (esValido)
                    {
                        MessageBox.Show("Usuario y contraseña son correctos!");
                        this.Hide();
                        MenuPrincipal menuPrincipal = new MenuPrincipal();

                        //Almacenamos los datos en las variables globales
                        Global.GlobalVarId = usuario.UsuarioID;
                        Global.GlobalVarNombre = usuario.Nombre;
                        Global.GlobalVarClave = usuario.Clave;
                        Global.GlobalVarIdPerfil = (int)usuario.IdPerfil;
                        Global.GlobalVarPerfil = usuario.Perfil;

                        //Llenamos el textbox del modal Menú principal
                        menuPrincipal.txtUsuarioMenu.Text = Global.GlobalVarNombre;
                        menuPrincipal.ShowDialog();

                    } else {
                        MessageBox.Show("Usuario o contraseña no son correctos!");
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

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Estás seguro de que quieres salir?", "Confirmación", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true; // Cancelar el cierre del formulario
            }
        }   
    }
}