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
            btAtras = new Button();
            label3 = new Label();
            txtEditUsuarioClave = new TextBox();
            txtEditUsuarioNombre = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnActualizar = new Button();
            label4 = new Label();
            cbPerfiles = new ComboBox();
            SuspendLayout();
            // 
            // btAtras
            // 
            btAtras.Location = new Point(50, 361);
            btAtras.Name = "btAtras";
            btAtras.Size = new Size(134, 29);
            btAtras.TabIndex = 12;
            btAtras.Text = "Atras";
            btAtras.UseVisualStyleBackColor = true;
            btAtras.Click += btAtras_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.GhostWhite;
            label3.Font = new Font("Modern No. 20", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(50, 49);
            label3.Name = "label3";
            label3.Size = new Size(259, 31);
            label3.TabIndex = 11;
            label3.Text = "Actualizar usuario";
            // 
            // txtEditUsuarioClave
            // 
            txtEditUsuarioClave.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtEditUsuarioClave.Location = new Point(50, 226);
            txtEditUsuarioClave.Name = "txtEditUsuarioClave";
            txtEditUsuarioClave.Size = new Size(291, 34);
            txtEditUsuarioClave.TabIndex = 10;
            // 
            // txtEditUsuarioNombre
            // 
            txtEditUsuarioNombre.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtEditUsuarioNombre.Location = new Point(50, 143);
            txtEditUsuarioNombre.Name = "txtEditUsuarioNombre";
            txtEditUsuarioNombre.Size = new Size(291, 34);
            txtEditUsuarioNombre.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 203);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 8;
            label2.Text = "Contraseña";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 120);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 7;
            label1.Text = "Usuario";
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(207, 361);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(134, 29);
            btnActualizar.TabIndex = 13;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(50, 280);
            label4.Name = "label4";
            label4.Size = new Size(42, 20);
            label4.TabIndex = 14;
            label4.Text = "Perfil";
            // 
            // cbPerfiles
            // 
            cbPerfiles.FormattingEnabled = true;
            cbPerfiles.Items.AddRange(new object[] { "Administrador", "Cajero", "Vendedor" });
            cbPerfiles.Location = new Point(50, 303);
            cbPerfiles.Name = "cbPerfiles";
            cbPerfiles.Size = new Size(291, 28);
            cbPerfiles.TabIndex = 18;
            // 
            // mdlEditarUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}