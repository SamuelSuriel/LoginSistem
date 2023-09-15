using LoginSistem.Clases;
using LoginSistem.Forms;

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

            this.Hide();
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

            ////Abrir el modal
            mdlEditarUsuario mdlEditarUsuario = new mdlEditarUsuario();
            mdlEditarUsuario.ShowDialog();

            int idPerfilUsuario = Global.GlobalVarPerfil;
            string perfil = "";
            if (idPerfilUsuario == 1)
            {
                perfil = "Administrador";
            }
            else if (idPerfilUsuario == 2)
            {
                perfil = "Cajero";
            }
            else if (idPerfilUsuario == 3)
            {
                perfil = "Vendedor";
            }
            //Asignar valores
            mdlEditarUsuario.txtEditUsuarioNombre.Text = Global.GlobalVarNombre;
            mdlEditarUsuario.txtEditUsuarioClave.Text = Global.GlobalVarClave;
            mdlEditarUsuario.cbPerfiles.SelectedText = perfil;

        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            int idPerfilUsuario = Global.GlobalVarPerfil;
            if (idPerfilUsuario == 1)
            {
                lblPerfil.Text = "Administrador";
            }
            else if (idPerfilUsuario == 2)
            {
                lblPerfil.Text = "Cajero";
            }
            else if (idPerfilUsuario == 3)
            {
                lblPerfil.Text = "Vendedor";
            }
        }
    }
}
