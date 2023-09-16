namespace LoginSistem.Forms
{
    partial class mdlEditarUsuario
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
            components = new System.ComponentModel.Container();
            btAtras = new Button();
            label3 = new Label();
            txtEditUsuarioClave = new TextBox();
            txtEditUsuarioNombre = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnActualizar = new Button();
            label4 = new Label();
            cbPerfiles = new ComboBox();
            perfilesBindingSource = new BindingSource(components);
            chkVerContraseña = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)perfilesBindingSource).BeginInit();
            SuspendLayout();
            // 
            // btAtras
            // 
            btAtras.BackColor = Color.FromArgb(255, 192, 192);
            btAtras.Cursor = Cursors.Hand;
            btAtras.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btAtras.ForeColor = Color.White;
            btAtras.Location = new Point(9, 359);
            btAtras.Name = "btAtras";
            btAtras.Size = new Size(242, 52);
            btAtras.TabIndex = 12;
            btAtras.Text = "Atras";
            btAtras.UseVisualStyleBackColor = false;
            btAtras.Click += btAtras_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.GhostWhite;
            label3.Font = new Font("Segoe UI Variable Display", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(64, 64, 64);
            label3.Location = new Point(153, 26);
            label3.Name = "label3";
            label3.Size = new Size(361, 53);
            label3.TabIndex = 11;
            label3.Text = "Actualizar usuario";
            // 
            // txtEditUsuarioClave
            // 
            txtEditUsuarioClave.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtEditUsuarioClave.Location = new Point(173, 221);
            txtEditUsuarioClave.MaxLength = 20;
            txtEditUsuarioClave.Name = "txtEditUsuarioClave";
            txtEditUsuarioClave.Size = new Size(291, 34);
            txtEditUsuarioClave.TabIndex = 10;
            // 
            // txtEditUsuarioNombre
            // 
            txtEditUsuarioNombre.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtEditUsuarioNombre.Location = new Point(173, 140);
            txtEditUsuarioNombre.MaxLength = 50;
            txtEditUsuarioNombre.Name = "txtEditUsuarioNombre";
            txtEditUsuarioNombre.Size = new Size(291, 34);
            txtEditUsuarioNombre.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Display", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(173, 189);
            label2.Name = "label2";
            label2.Size = new Size(138, 31);
            label2.TabIndex = 8;
            label2.Text = "Contraseña";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Display", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(173, 106);
            label1.Name = "label1";
            label1.Size = new Size(97, 31);
            label1.TabIndex = 7;
            label1.Text = "Usuario";
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.FromArgb(192, 192, 255);
            btnActualizar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnActualizar.ForeColor = Color.White;
            btnActualizar.Location = new Point(341, 359);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(239, 52);
            btnActualizar.TabIndex = 13;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Variable Display", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Gray;
            label4.Location = new Point(173, 266);
            label4.Name = "label4";
            label4.Size = new Size(70, 31);
            label4.TabIndex = 14;
            label4.Text = "Perfil";
            // 
            // cbPerfiles
            // 
            cbPerfiles.FormattingEnabled = true;
            cbPerfiles.Items.AddRange(new object[] { "Administrador", "Cajero", "Vendedor" });
            cbPerfiles.Location = new Point(173, 300);
            cbPerfiles.Name = "cbPerfiles";
            cbPerfiles.Size = new Size(291, 28);
            cbPerfiles.TabIndex = 18;
            // 
            // perfilesBindingSource
            // 
            perfilesBindingSource.DataSource = typeof(Clases.Perfiles);
            // 
            // chkVerContraseña
            // 
            chkVerContraseña.AutoSize = true;
            chkVerContraseña.ForeColor = Color.Gray;
            chkVerContraseña.Location = new Point(482, 221);
            chkVerContraseña.Name = "chkVerContraseña";
            chkVerContraseña.Size = new Size(155, 24);
            chkVerContraseña.TabIndex = 19;
            chkVerContraseña.Text = "Ocultar contraseña";
            chkVerContraseña.UseVisualStyleBackColor = true;
            chkVerContraseña.CheckedChanged += chkVerContraseña_CheckedChanged;
            // 
            // mdlEditarUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(666, 466);
            Controls.Add(chkVerContraseña);
            Controls.Add(cbPerfiles);
            Controls.Add(label4);
            Controls.Add(btnActualizar);
            Controls.Add(btAtras);
            Controls.Add(label3);
            Controls.Add(txtEditUsuarioClave);
            Controls.Add(txtEditUsuarioNombre);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "mdlEditarUsuario";
            Text = "Editar Usuario";
            Load += mdlEditarUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)perfilesBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btAtras;
        private Label label3;
        public TextBox txtEditUsuarioClave;
        public TextBox txtEditUsuarioNombre;
        private Label label2;
        private Label label1;
        private Button btnActualizar;
        private Label label4;
        public ComboBox cbPerfiles;
        private BindingSource perfilesBindingSource;
        private CheckBox chkVerContraseña;
    }
}