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
    public partial class Inicio : Form
    {
        private Soundtrack Soundtrack;
        public Inicio()
        {
            InitializeComponent();
            Soundtrack = new Soundtrack();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new Login();
            form.ShowDialog();
            this.Show();
        }
    }
}
