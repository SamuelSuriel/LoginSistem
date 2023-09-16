namespace LoginSistem
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            txtUsuarioMenu = new TextBox();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            btnCerrarSesion = new Button();
            btnComboForm = new Button();
            btnEditarUsuario = new Button();
            lblPerfil = new Label();
            dgvUsuarios = new DataGridView();
            label04 = new Label();
            lbltituloPerfil = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // txtUsuarioMenu
            // 
            txtUsuarioMenu.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtUsuarioMenu.Location = new Point(36, 186);
            txtUsuarioMenu.MaxLength = 50;
            txtUsuarioMenu.Name = "txtUsuarioMenu";
            txtUsuarioMenu.ReadOnly = true;
            txtUsuarioMenu.Size = new Size(321, 34);
            txtUsuarioMenu.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.GhostWhite;
            label3.Font = new Font("Segoe UI Variable Display", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(64, 64, 64);
            label3.Location = new Point(52, 46);
            label3.Name = "label3";
            label3.Size = new Size(305, 53);
            label3.TabIndex = 4;
            label3.Text = "Menú Principal";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(843, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(167, 123);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.BackColor = Color.FromArgb(255, 192, 192);
            btnCerrarSesion.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCerrarSesion.ForeColor = SystemColors.ButtonHighlight;
            btnCerrarSesion.Location = new Point(12, 446);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(155, 51);
            btnCerrarSesion.TabIndex = 6;
            btnCerrarSesion.Text = "Cerrar sesión";
            btnCerrarSesion.UseVisualStyleBackColor = false;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // btnComboForm
            // 
            btnComboForm.BackColor = Color.Silver;
            btnComboForm.ForeColor = Color.FromArgb(64, 64, 64);
            btnComboForm.Location = new Point(644, 514);
            btnComboForm.Name = "btnComboForm";
            btnComboForm.Size = new Size(151, 48);
            btnComboForm.TabIndex = 7;
            btnComboForm.Text = "Combo Form";
            btnComboForm.UseVisualStyleBackColor = false;
            btnComboForm.Click += btnComboForm_Click;
            // 
            // btnEditarUsuario
            // 
            btnEditarUsuario.BackColor = Color.FromArgb(192, 192, 255);
            btnEditarUsuario.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEditarUsuario.ForeColor = SystemColors.ButtonHighlight;
            btnEditarUsuario.Location = new Point(206, 446);
            btnEditarUsuario.Name = "btnEditarUsuario";
            btnEditarUsuario.Size = new Size(151, 48);
            btnEditarUsuario.TabIndex = 8;
            btnEditarUsuario.Text = "Editar usuario";
            btnEditarUsuario.UseVisualStyleBackColor = false;
            btnEditarUsuario.Click += btnEditarUsuario_Click;
            // 
            // lblPerfil
            // 
            lblPerfil.AutoSize = true;
            lblPerfil.BackColor = Color.GhostWhite;
            lblPerfil.Font = new Font("Segoe UI Variable Display Semib", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblPerfil.ForeColor = Color.Gray;
            lblPerfil.Location = new Point(36, 270);
            lblPerfil.Name = "lblPerfil";
            lblPerfil.Size = new Size(17, 27);
            lblPerfil.TabIndex = 9;
            lblPerfil.Text = " ";
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Location = new Point(433, 186);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.RowHeadersWidth = 51;
            dgvUsuarios.RowTemplate.Height = 29;
            dgvUsuarios.Size = new Size(577, 311);
            dgvUsuarios.TabIndex = 10;
            // 
            // label04
            // 
            label04.AutoSize = true;
            label04.Font = new Font("Segoe UI Variable Display", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label04.ForeColor = Color.Gray;
            label04.Location = new Point(36, 233);
            label04.Name = "label04";
            label04.Size = new Size(76, 31);
            label04.TabIndex = 11;
            label04.Text = "Perfil:";
            // 
            // lbltituloPerfil
            // 
            lbltituloPerfil.AutoSize = true;
            lbltituloPerfil.Font = new Font("Segoe UI Variable Display", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbltituloPerfil.ForeColor = Color.Gray;
            lbltituloPerfil.Location = new Point(433, 155);
            lbltituloPerfil.Name = "lbltituloPerfil";
            lbltituloPerfil.Size = new Size(198, 31);
            lbltituloPerfil.TabIndex = 12;
            lbltituloPerfil.Text = "Lista de usuarios:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Variable Display", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Gray;
            label4.Location = new Point(36, 152);
            label4.Name = "label4";
            label4.Size = new Size(191, 31);
            label4.TabIndex = 13;
            label4.Text = "Bienvenido Sr/a:";
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1050, 605);
            Controls.Add(label4);
            Controls.Add(lbltituloPerfil);
            Controls.Add(label04);
            Controls.Add(dgvUsuarios);
            Controls.Add(lblPerfil);
            Controls.Add(btnEditarUsuario);
            Controls.Add(btnComboForm);
            Controls.Add(btnCerrarSesion);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(txtUsuarioMenu);
            Name = "MenuPrincipal";
            Text = "Menu Principal";
            Load += MenuPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private PictureBox pictureBox1;
        private Button btnCerrarSesion;
        public TextBox txtUsuarioMenu;
        private Button btnComboForm;
        private Button btnEditarUsuario;
        private DataGridView dgvUsuarios;
        private Label label04;
        private Label lbltituloPerfil;
        private Label label4;
        public Label lblPerfil;
    }
}