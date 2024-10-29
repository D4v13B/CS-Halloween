using Parcial2.Back;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial2
{
    public partial class Registro : Form
    {
        private string _filename;
        private Db _db;
        public Registro()
        {
            InitializeComponent();
            _db = new Db();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "archivos de imagenes (*.png; .*jpg)| *.png; *jpg";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(ofd.FileName);
                this._filename = ofd.FileName;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var nombre = txtUsuario.Text;
            var password = txtPassword.Text;
            var codigo = "12345";
            string skin = Path.GetFileNameWithoutExtension(_filename);
            MemoryStream ms = new MemoryStream();

            if (pictureBox1.Image != null)
            {
                pictureBox1.Image.Save(ms, ImageFormat.Jpeg);
            }
            byte[] aByte = ms.ToArray();

            if (_db.registrarCliente(nombre, password, codigo, skin, aByte))
            {
                MessageBox.Show("Usuario registrado!... Codigo: 12345", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUsuario.Text = null;
                txtPassword.Text = null;
                pictureBox1.Image = null;
                _filename = "";
            }
            else
            {
                MessageBox.Show("Error al momento de registrar! Usuario repetido o faltan datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
