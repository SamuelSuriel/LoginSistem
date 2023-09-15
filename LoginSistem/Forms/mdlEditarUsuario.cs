using LoginSistem.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginSistem.Forms
{
    public partial class mdlEditarUsuario : Form
    {
        public mdlEditarUsuario()
        {
            InitializeComponent();
        }

        private void btAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuPrincipal menuPrincipal = new MenuPrincipal();

            menuPrincipal.txtUsuarioMenu.Text = Global.GlobalVarNombre;
            menuPrincipal.txtPasswordMenu.PlaceholderText = Global.GlobalVarClave;

            menuPrincipal.ShowDialog();
        }

        private void mdlEditarUsuario_Load(object sender, EventArgs e)
        {
            txtEditUsuarioNombre.Text = Global.GlobalVarNombre;
            txtEditUsuarioClave.Text = Global.GlobalVarClave;

        }

        private void cbPerfiles_SelectedIndexChanged(object sender, EventArgs e)
        {
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
            cbPerfiles.SelectedText = perfil;
        }
    }
}
