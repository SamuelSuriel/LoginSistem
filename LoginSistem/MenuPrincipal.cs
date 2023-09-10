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

    }
}
