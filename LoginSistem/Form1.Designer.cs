﻿namespace LoginSistem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtPassword = new TextBox();
            btnAcceder = new Button();
            btnCancelar = new Button();
            txtUsuario = new TextBox();
            label2 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Modern No. 20", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(146, 76);
            label1.Name = "label1";
            label1.Size = new Size(188, 31);
            label1.TabIndex = 0;
            label1.Text = "Login System";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(62, 248);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(373, 27);
            txtPassword.TabIndex = 1;
            // 
            // btnAcceder
            // 
            btnAcceder.ForeColor = Color.Green;
            btnAcceder.Location = new Point(302, 354);
            btnAcceder.Name = "btnAcceder";
            btnAcceder.Size = new Size(133, 54);
            btnAcceder.TabIndex = 2;
            btnAcceder.Text = "Acceder";
            btnAcceder.UseVisualStyleBackColor = true;
            btnAcceder.Click += btnAcceder_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.ForeColor = Color.Crimson;
            btnCancelar.Location = new Point(62, 354);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(143, 54);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(62, 177);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(373, 27);
            txtUsuario.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Modern No. 20", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Blue;
            label2.Location = new Point(62, 144);
            label2.Name = "label2";
            label2.Size = new Size(111, 30);
            label2.TabIndex = 5;
            label2.Text = "Usuario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Modern No. 20", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Blue;
            label3.Location = new Point(62, 215);
            label3.Name = "label3";
            label3.Size = new Size(148, 30);
            label3.TabIndex = 6;
            label3.Text = "Contraseña";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.img_list;
            pictureBox1.Location = new Point(461, 134);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(300, 200);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtUsuario);
            Controls.Add(btnCancelar);
            Controls.Add(btnAcceder);
            Controls.Add(txtPassword);
            Controls.Add(label1);
            ForeColor = SystemColors.ActiveCaption;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtPassword;
        private Button btnAcceder;
        private Button btnCancelar;
        private TextBox txtUsuario;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox1;
    }
}