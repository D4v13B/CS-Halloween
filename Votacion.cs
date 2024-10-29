using Parcial2.Back;
using Parcial2.Back.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial2
{
    public partial class Votacion : Form
    {
        private Db _db;
        private List<User> _listInvitados;
        private int _pageIndex = 0;

        private int userId = 0;
        private int punctuation;
        public Votacion()
        {
            InitializeComponent();
            _db = new Db();
            _listInvitados = _db.LeerInvitados();
            mostrarDisfraz(_listInvitados[_pageIndex]);
            txtPuntuacion.Minimum = 0;
            txtPuntuacion.Maximum = 10;
        }

        private void btnVotar_Click(object sender, EventArgs e)
        {
            //Llamar la funcion que me envia el puntaje
            if(_db.VotarDisfraz(Convert.ToInt32(txtPuntuacion.Text), userId))
            {
                MessageBox.Show("Su voto se envio correctamente");
                lblPuntos.Text = $"Puntos del disfraz {this.punctuation + Convert.ToInt32(txtPuntuacion.Text)}";
            }
            else
            {
                MessageBox.Show("No se ha logrado enviar el voto");
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            _pageIndex++;
            if(_pageIndex > _listInvitados.Count - 1) { 
                _pageIndex = 0; 
            }
            mostrarDisfraz(_listInvitados[_pageIndex]);
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            _pageIndex--;
            if (_pageIndex < 0)
            {
                _pageIndex = _listInvitados.Count - 1;
            }
            mostrarDisfraz(_listInvitados[_pageIndex]);
        }

        public void mostrarDisfraz(User user)
        {
            if (user.skin != null && user.skinPhoto.Length > 0)
            {
                userId = user.id;
                MemoryStream ms = new MemoryStream(user.skinPhoto);
                pbDisfraz.Image = Image.FromStream(ms);
            }
            lblPuntos.Text = $"Puntos del disfraz {user.punctuation}";
            this.punctuation = user.punctuation;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        
    }
}
