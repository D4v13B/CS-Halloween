using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial2
{
    public partial class MenuCliente : Form
    {
        public MenuCliente()
        {
            InitializeComponent();
        }

        private void MostrarMenuHijo(Form form)
        {
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MostrarMenuHijo(new Votacion());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MostrarMenuHijo(new Ranking());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MostrarMenuHijo(new Parada());
        }
    }
}
