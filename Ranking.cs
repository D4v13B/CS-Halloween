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
using Parcial2.Back;
using Parcial2.Back.Models;

namespace Parcial2
{
    public partial class Ranking : Form
    {
        private Db _db;
        public Ranking()
        {
            InitializeComponent();
            _db = new Db();
            MostrarTop3();
        }

        private void Ranking_Load(object sender, EventArgs e)
        {

        }

        private void MostrarTop3()
        {
            List<User> topUsers = _db.Ranking();
            List<PictureBox> ranking = new List<PictureBox>() { pictureBox1, pictureBox2, pictureBox3 };

            for (int i = 0; i < topUsers.Count ; i++)
            {
                MostrarPuesto(topUsers[i], ranking[i]);
            }
        }

        public void MostrarPuesto(User user, PictureBox pb)
        {
            if (user.skin != null && user.skinPhoto.Length > 0)
            {
                MemoryStream ms = new MemoryStream(user.skinPhoto);
                pb.Image = Image.FromStream(ms);
            }

        }
    }
}
