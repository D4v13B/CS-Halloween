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
    public partial class AdminPar : Form
    {
        private Db _db;

        public AdminPar()
        {
            InitializeComponent();
            _db = new Db();
            MostrarCasas();
        }

        private void AdminPar_Load(object sender, EventArgs e)
        {

        }

        public void MostrarCasas()
        {
            List<Stop> stops = _db.LeerParadas();
            Console.WriteLine(stops.Count);

            DataTable table = new DataTable();

            table.Columns.Add("Nombre", typeof(string));
            table.Columns.Add("Cantidad de Dulces", typeof(string));
            foreach (Stop stop in stops)
            {
                table.Rows.Add(stop.name, stop.sweetActualQuantity);
            }

            dataGridView1.DataSource = table;
        }

        private void btnRegistrarCasa_Click(object sender, EventArgs e)
        {
            var nombreCasa = txtNombreCasa.Text;
            var tiposDulces = txtTipoDulces.Text;
            var quantity = Convert.ToInt32(txtQuantity.Text);

            if(_db.CrearCasa(nombreCasa, quantity, tiposDulces))
            {
                MessageBox.Show("Se ha logrado registrar la casa");
            }
        }
    }
}
