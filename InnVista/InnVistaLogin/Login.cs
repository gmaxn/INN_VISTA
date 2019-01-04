using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InnVistaLogin
{
    public partial class Login : Form
    {
        NuevoUsuario frmGeneradorUsuario;
        public Login()
        {
            InitializeComponent();
        }

        private void btn_nuevoUsuario_Click(object sender, EventArgs e)
        {
            frmGeneradorUsuario = new NuevoUsuario(this);
            frmGeneradorUsuario.Show();
            this.Hide();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (/*this.u.nombreusuario == this.tbx_nombreusuario.text*/true)
                if (/*this.u.password == this.tbx_password*/true)
                {
                    //this.frmadministradorestablecimientos.show();
                    this.frmGeneradorUsuario.Close();
                }

            MessageBox.Show("Nombre de Usuario o Contraseña incorrectos");
        }
    }
}
