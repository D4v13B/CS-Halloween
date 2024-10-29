using Parcial2.Back;
using Parcial2.Back.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial2
{
    public partial class Admin : Form
    {
        private string _filename;
        private Db _db;
        public Admin()
        {
            InitializeComponent();
            _db = new Db();
            MostrarListClientes();
        }

        private void MostrarListClientes()
        {
            List<User> users = _db.LeerInvitados();

            DataTable table = new DataTable();

            table.Columns.Add("Nombre", typeof(string));
            table.Columns.Add("Disfraz", typeof(string));
            table.Columns.Add("Código", typeof(string));
            foreach (User user in users)
            {
                table.Rows.Add(user.name, user.skin, user.code);
            }

            dataGridView1.DataSource = table;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            var nombre = txtNombre.Text;
            var password = txtGestContraseña.Text;
            var codigo = txtGestCod.Text;
            string skin = Path.GetFileNameWithoutExtension(_filename);
            MemoryStream ms = new MemoryStream();

            if (pcbGestDisfraz.Image != null)
            {
                pcbGestDisfraz.Image.Save(ms, ImageFormat.Jpeg);
            }
            byte[] aByte = ms.ToArray();

            if (_db.registrarCliente(nombre, password, codigo, skin, aByte))
            {
                MessageBox.Show("Data inserted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNombre.Text = null;
                txtGestContraseña.Text = null;
                txtGestCod.Text = null;
                pcbGestDisfraz.Image = null;
                _filename = "";
                MostrarListClientes();
            }
            else
            {
                MessageBox.Show("Error al momento de registrar! Usuario repetido o faltan datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "archivos de imagenes (*.png; .*jpg)| *.png; *jpg";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pcbGestDisfraz.Image = Image.FromFile(ofd.FileName);
                this._filename = ofd.FileName;
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
