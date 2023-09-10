namespace LoginSistem
{
    public partial class ComboBoxForm : Form
    {
        public ComboBoxForm()
        {
            InitializeComponent();
        }

        private void ComboBoxForm_Load(object sender, EventArgs e)
        {
            for (int f = 0; f <= 255; f++)
            {
                comboBox1.Items.Add(f);
                comboBox2.Items.Add(f);
                comboBox3.Items.Add(f);
            }
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int rojo = int.Parse(comboBox1.Text);
            int verde = int.Parse(comboBox2.Text);
            int azul = int.Parse(comboBox3.Text);
            BackColor = Color.FromArgb(rojo, verde, azul);
        }

    }
}
