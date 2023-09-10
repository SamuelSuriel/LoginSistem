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
            label1 = new Label();
            label2 = new Label();
            txtUsuarioMenu = new TextBox();
            txtPasswordMenu = new TextBox();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            btnEditarUsuario = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 163);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 0;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 245);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 1;
            label2.Text = "Contraseña";
            // 
            // txtUsuarioMenu
            // 
            txtUsuarioMenu.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtUsuarioMenu.Location = new Point(36, 186);
            txtUsuarioMenu.Name = "txtUsuarioMenu";
            txtUsuarioMenu.Size = new Size(291, 34);
            txtUsuarioMenu.TabIndex = 2;
            txtUsuarioMenu.TextChanged += txtUsuarioMenu_TextChanged;
            // 
            // txtPasswordMenu
            // 
            txtPasswordMenu.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtPasswordMenu.Location = new Point(36, 268);
            txtPasswordMenu.Name = "txtPasswordMenu";
            txtPasswordMenu.Size = new Size(291, 34);
            txtPasswordMenu.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.GhostWhite;
            label3.Font = new Font("Modern No. 20", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(36, 66);
            label3.Name = "label3";
            label3.Size = new Size(222, 31);
            label3.TabIndex = 4;
            label3.Text = "Menú Principal";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(407, 84);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(306, 250);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(103, 367);
            button1.Name = "button1";
            button1.Size = new Size(134, 29);
            button1.TabIndex = 6;
            button1.Text = "Cerrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(591, 367);
            button2.Name = "button2";
            button2.Size = new Size(113, 29);
            button2.TabIndex = 7;
            button2.Text = "ComboForm";
            button2.UseVisualStyleBackColor = true;
            button2.Visible = false;
            button2.Click += button2_Click;
            // 
            // btnEditarUsuario
            // 
            btnEditarUsuario.Location = new Point(425, 367);
            btnEditarUsuario.Name = "btnEditarUsuario";
            btnEditarUsuario.Size = new Size(113, 29);
            btnEditarUsuario.TabIndex = 8;
            btnEditarUsuario.Text = "Editar usuario";
            btnEditarUsuario.UseVisualStyleBackColor = true;
            btnEditarUsuario.Click += btnEditarUsuario_Click;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEditarUsuario);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(txtPasswordMenu);
            Controls.Add(txtUsuarioMenu);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "MenuPrincipal";
            Text = "MenuPrincipal";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox1;
        private Button button1;
        public TextBox txtUsuarioMenu;
        public TextBox txtPasswordMenu;
        private Button button2;
        private Button btnEditarUsuario;
    }
}