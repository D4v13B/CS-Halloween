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
    public partial class Parada : Form
    {
        private Db _db;
        public Parada()
        {
            InitializeComponent();
            _db = new Db();
            MostrarCasitas();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        public void MostrarCasitas()
        {
            List<Stop> stops = _db.LeerParadas();

            // Crea un generador de números aleatorios
            Random rand = new Random();

            // Obtiene las dimensiones del botón
            int buttonWidth = btnTemplate.Width;
            int buttonHeight = btnTemplate.Height;

            // Determina el área utilizable del formulario
            int maxX = this.ClientSize.Width - buttonWidth; // Ajusta el ancho
            int maxY = this.ClientSize.Height - buttonHeight; // Ajusta la altura

            foreach (Stop stop in stops)
            {
                // Genera posiciones aleatorias dentro de los límites del formulario
                int posX = rand.Next(0, maxX); // Posición X aleatoria
                int posY = rand.Next(0, maxY); // Posición Y aleatoria

                ClonarBoton(stop, posX, posY);
            }
        }

        private void ClonarBoton(Stop stop, int posX, int posY)
        {
            var newButton = new Button();
            newButton.BackgroundImage = btnTemplate.BackgroundImage;
            newButton.BackgroundImageLayout = btnTemplate.BackgroundImageLayout;
            newButton.Height = btnTemplate.Height;
            newButton.Width = btnTemplate.Width;
            newButton.Name = "btnCasita" + stop.id;
            newButton.Visible = true;
            newButton.Tag = stop;

            // Asigna la posición aleatoria generada
            newButton.Location = new Point(posX, posY);
            newButton.Click += CasitasButton_Click;

            // Fake blanco y negro
            if (stop.sweetActualQuantity <= 0)
            {
                newButton.Enabled = false;
            }

            Controls.Add(newButton);
        }

        private void CasitasButton_Click(object sender, EventArgs e)
        {
            var casita = (Button)sender;
            //MessageBox.Show("Casita" + casita.Name);
            Form form = new QuitarDulces((Stop)casita.Tag);
            form.ShowDialog();
        }

        private void btnTemplate_Click(object sender, EventArgs e)
        {

        }
    }
}
