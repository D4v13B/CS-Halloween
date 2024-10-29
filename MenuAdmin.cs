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
    public partial class MenuAdmin : Form
    {
        public MenuAdmin()
        {
            InitializeComponent();
        }

        private void MostrarMenuHijo(Form form)
        {
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        //Menu de clientes
        private void button1_Click(object sender, EventArgs e)
        {
            MostrarMenuHijo(new Admin());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MostrarMenuHijo(new AdminPar());
        }

        private void btnRanking_Click(object sender, EventArgs e)
        {
            MostrarMenuHijo(new Ranking());
        }
    }
}
