namespace InnVistaLogin
{
    partial class Login
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
            this.lbl_userName = new System.Windows.Forms.Label();
            this.tbx_nombreUsuario = new System.Windows.Forms.TextBox();
            this.tbx_password = new System.Windows.Forms.TextBox();
            this.lbl_password = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_nuevoUsuario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_userName
            // 
            this.lbl_userName.AutoSize = true;
            this.lbl_userName.Location = new System.Drawing.Point(20, 10);
            this.lbl_userName.Name = "lbl_userName";
            this.lbl_userName.Size = new System.Drawing.Size(57, 17);
            this.lbl_userName.TabIndex = 0;
            this.lbl_userName.Text = "Usuario";
            // 
            // tbx_nombreUsuario
            // 
            this.tbx_nombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_nombreUsuario.ForeColor = System.Drawing.Color.Black;
            this.tbx_nombreUsuario.Location = new System.Drawing.Point(20, 37);
            this.tbx_nombreUsuario.Name = "tbx_nombreUsuario";
            this.tbx_nombreUsuario.Size = new System.Drawing.Size(200, 22);
            this.tbx_nombreUsuario.TabIndex = 1;
            this.tbx_nombreUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbx_password
            // 
            this.tbx_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_password.ForeColor = System.Drawing.Color.Black;
            this.tbx_password.Location = new System.Drawing.Point(20, 96);
            this.tbx_password.Name = "tbx_password";
            this.tbx_password.PasswordChar = '*';
            this.tbx_password.Size = new System.Drawing.Size(200, 22);
            this.tbx_password.TabIndex = 3;
            this.tbx_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Location = new System.Drawing.Point(20, 69);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(81, 17);
            this.lbl_password.TabIndex = 2;
            this.lbl_password.Text = "Contraseña";
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(20, 135);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(90, 25);
            this.btn_login.TabIndex = 4;
            this.btn_login.Text = "ingresar";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_nuevoUsuario
            // 
            this.btn_nuevoUsuario.Location = new System.Drawing.Point(130, 135);
            this.btn_nuevoUsuario.Name = "btn_nuevoUsuario";
            this.btn_nuevoUsuario.Size = new System.Drawing.Size(90, 25);
            this.btn_nuevoUsuario.TabIndex = 5;
            this.btn_nuevoUsuario.Text = "nuevo";
            this.btn_nuevoUsuario.UseVisualStyleBackColor = true;
            this.btn_nuevoUsuario.Click += new System.EventHandler(this.btn_nuevoUsuario_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 178);
            this.Controls.Add(this.btn_nuevoUsuario);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.tbx_password);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.tbx_nombreUsuario);
            this.Controls.Add(this.lbl_userName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inn Vista (Login)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_userName;
        private System.Windows.Forms.TextBox tbx_nombreUsuario;
        private System.Windows.Forms.TextBox tbx_password;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_nuevoUsuario;
    }
}