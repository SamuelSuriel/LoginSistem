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

            if (usuarioValido == "samuelramirez" && passwordValido == "1234")
            {
                esValido = true;
            }

            if (usuarioValido != string.Empty && passwordValido != string.Empty)
            {
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