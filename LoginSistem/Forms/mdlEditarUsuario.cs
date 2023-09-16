using LoginSistem.Clases;
using Microsoft.Data.SqlClient;
using System.Data;

namespace LoginSistem.Forms
{
    public partial class mdlEditarUsuario : Form
    {
        public mdlEditarUsuario()
        {
            InitializeComponent();
        }
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();
        private void btAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuPrincipal menuPrincipal = new MenuPrincipal();
            menuPrincipal.txtUsuarioMenu.Text = Global.GlobalVarNombre;
            menuPrincipal.lblPerfil.Text = Global.GlobalVarPerfil;
            menuPrincipal.ShowDialog();
        }

        private void mdlEditarUsuario_Load(object sender, EventArgs e)
        {
            txtEditUsuarioNombre.Text = Global.GlobalVarNombre;
            txtEditUsuarioClave.Text = Global.GlobalVarClave;
            cbPerfiles.Text = Global.GlobalVarPerfil;

            txtEditUsuarioClave.MaxLength = 20;
            txtEditUsuarioNombre.MaxLength = 50;
        }

        private void chkVerContraseña_CheckedChanged(object sender, EventArgs e)
        {
            txtEditUsuarioClave.PasswordChar = chkVerContraseña.Checked ? '*' : '\0';

        }

        private SqlConnection Conexion = new SqlConnection(@"server=LEVHDLL; Database=Ventas; integrated security =True; TrustServerCertificate=True");

        public SqlConnection AbrirConexion()
        {
            if (Conexion.State == ConnectionState.Closed)
                Conexion.Open();
            return Conexion;
        }

        public SqlConnection CerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
            return Conexion;
        }
        public void Editar(int id, string nombre, string clave, int idPerfil)
        {

            comando.Connection = AbrirConexion();
            comando.CommandText = "EditarUsuario";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id", id);
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@clave", clave);
            comando.Parameters.AddWithValue("@idPerfil", idPerfil);

            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }

        public void EditarProd(int id, string nombre, string clave, int idPerfil)
        {
            Editar(Convert.ToInt32(id), nombre, clave, Convert.ToInt32(idPerfil));
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            int id = Global.GlobalVarId;
            string name = txtEditUsuarioNombre.Text;
            string passw = txtEditUsuarioClave.Text;
            string perfil = cbPerfiles.Text;

            if (perfil == "Administrador")
            {
                Global.GlobalVarIdPerfil = 1;
            }
            else if (perfil == "Cajero")
            {
                Global.GlobalVarIdPerfil = 2;
            }
            else if (perfil == "Vendedor")
            {
                Global.GlobalVarIdPerfil = 3;
            }
            int idPerfil = Global.GlobalVarIdPerfil;

            EditarProd(id, name, passw, idPerfil);

            string query = "SELECT u.UsuarioID, u.Nombre, u.Clave, u.IdPerfil, p.Perfil FROM Usuarios u INNER JOIN Perfiles p on u.IdPerfil = p.IdPerfil WHERE UsuarioID = " + id;
            comando = new SqlCommand(query, Conexion);
            SqlDataReader registro = comando.ExecuteReader();

            if (registro.Read())
            {
                Global.GlobalVarId = (int)registro["UsuarioID"];
                Global.GlobalVarNombre = (string)registro["Nombre"];
                Global.GlobalVarClave = (string)registro["Clave"];
                Global.GlobalVarIdPerfil = (int)registro["IdPerfil"];
                Global.GlobalVarPerfil = (string)registro["Perfil"];

            }
            MessageBox.Show("Se editó correctamente");
        }
    }
}
