using LoginSistem.Clases;
using LoginSistem.Forms;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace LoginSistem
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Hide();
            //Limpiamos los datos en las variables globales
            Global.GlobalVarId = 0;
            Global.GlobalVarNombre = "";
            Global.GlobalVarClave = "";
            Global.GlobalVarIdPerfil = 0;
            Global.GlobalVarPerfil = "";

            //volvemos al formulario de login
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void btnComboForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            ComboBoxForm comboBoxForm = new ComboBoxForm();
            comboBoxForm.ShowDialog();
        }

        private void btnEditarUsuario_Click(object sender, EventArgs e)
        {
            this.Hide();

            ////Abrir el modal
            mdlEditarUsuario mdlEditarUsuario = new mdlEditarUsuario();
            mdlEditarUsuario.ShowDialog();

            //Asignar valores a los textbox y combo
            mdlEditarUsuario.txtEditUsuarioNombre.Text = Global.GlobalVarNombre;
            mdlEditarUsuario.txtEditUsuarioClave.Text = Global.GlobalVarClave;
            mdlEditarUsuario.cbPerfiles.Text = Global.GlobalVarPerfil;

        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            lblPerfil.Text = Global.GlobalVarPerfil;

            int idPerfilUsuario = Global.GlobalVarIdPerfil;
            mdlEditarUsuario mdlEditarUsuario = new mdlEditarUsuario();
            //Mostramos diferentes controles según el perfil del usuario logueado
            if (idPerfilUsuario == 1)
            {
                lbltituloPerfil.Visible = true;
                dgvUsuarios.Visible = true;
                btnComboForm.Visible = false;
                dgvUsuarios.DataSource = MostrarProd();
                mdlEditarUsuario.label4.Visible = true;
                mdlEditarUsuario.cbPerfiles.Visible = true;
            }
            else if (idPerfilUsuario == 2)
            {
                lbltituloPerfil.Visible = false;
                dgvUsuarios.Visible = false;
                btnComboForm.Visible = true;
                mdlEditarUsuario.label4.Visible = false;
                mdlEditarUsuario.cbPerfiles.Visible = false;
            }
            else if (idPerfilUsuario == 3)
            {
                lbltituloPerfil.Visible = false;
                dgvUsuarios.Visible = false;
                btnComboForm.Visible = false;
                mdlEditarUsuario.label4.Visible = false;
                mdlEditarUsuario.cbPerfiles.Visible = false;
            }
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
        public DataTable Mostrar()
        {

            comando.Connection = AbrirConexion();
            comando.CommandText = "MostrarUsuarios";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            CerrarConexion();
            return tabla;

        }

        public DataTable MostrarProd()
        {
            DataTable tabla = new DataTable();
            tabla = Mostrar();
            return tabla;
        }
    }
}
