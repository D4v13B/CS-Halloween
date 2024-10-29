using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Parcial2.Back;
using Parcial2.Back.Models;

namespace Parcial2
{
    public partial class Login : Form
    {
        Db _db;
        public Login()
        {
            InitializeComponent();
            _db = new Db();
        }

        private void btnLogSig_Click(object sender, EventArgs e)
        {
            var usuario = txtUsuario.Text;
            var password = txtContraseña.Text;
            var codigo = txtCódigo.Text;

            User user = _db.AutenticarUsuario(usuario, password, codigo);

            if (user != null)
            {
                Form form;
                if (!user.isAdmin)
                {//Usuario invitado, activo con el disfraz puesto y registrado
                    this.Hide();
                    form = new MenuCliente();
                    form.ShowDialog();
                    return;
                }
                else
                {
                    this.Hide();
                    form = new MenuAdmin();
                    form.ShowDialog();
                    return;
                }
            }
            else
            {
                MessageBox.Show("Usuario y contraseña no coinciden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void lblLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form form = new Registro();
            form.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
