using Parcial2.Back.Models;
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

namespace Parcial2
{
    public partial class QuitarDulces : Form
    {
        private Stop stop;
        private Db _db;
        public QuitarDulces(Stop stop)
        {
            InitializeComponent();
            this.stop = stop;
            _db = new Db();
            lblNombre.Text = stop.name;
            lblDulcesDisponibles.Text = $"Dulces disponibles: {stop.sweetActualQuantity}";
        }

        private void btnLlevarDulces_Click(object sender, EventArgs e)
        {
            //Aqui vamos a actualizar el stock de los dulces
            var quantity = Convert.ToInt32(txtQuantity.Text);

            if(quantity < 0)
            {
                MessageBox.Show("No se ha podido actualizar");
                return;
            } 

            if (_db.ActualizarDulces(quantity, stop.id))
            {
                MessageBox.Show("Cantidad de dulces actualizada");
                lblDulcesDisponibles.Text = $"Dulces disponibles: {stop.sweetActualQuantity - quantity}";
            }
            else
            {
                MessageBox.Show("No se ha podido actualizar");
            }
        }
    }
}
