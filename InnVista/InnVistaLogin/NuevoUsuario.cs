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
    public partial class NuevoUsuario : Form
    {
        private Login formularioLogin;
        public NuevoUsuario(Login formulario)
        {
            InitializeComponent();
            this.formularioLogin = formulario;
        }

        private void btn_trampa_Click(object sender, EventArgs e)
        {
            this.tbx_usuario.Text = "Darth_Vader";
            this.tbx_email.Text = "askywalker@gmail.com";
            this.tbx_password.Text = "admin";
            this.tbx_confirm.Text = "admin";
            this.tbx_nombre.Text = "Anakin";
            this.tbx_apellidoUsuario.Text = "Skywalker";
            this.tbx_dni.Text = "00000000";
            this.btn_crearUsuario.Enabled = true;

        }


        private void NuevoUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.formularioLogin.Close();
        }

        private void tbx_password_TextChanged(object sender, EventArgs e)
        {
            this.lbl_confirm.Enabled = true;
            this.tbx_confirm.Enabled = true;
        }

        private void btn_crearUsuario_Click(object sender, EventArgs e)
        {
            this.formularioLogin.Show();
            //this.formularioLogin = null;
            this.Hide();
        }
    }
}
