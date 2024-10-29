using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2.Back.Models
{
    public class User
    {
        public int id { get; set; }
        public string name { get; set; }
        public string password { get; set; }
        public bool isAdmin { get; set; }
        public int active { get; set; }
        public string skin { get; set; }
        public byte[] skinPhoto { get; set; }
        public int code { get; set; }
        public int punctuation { get; set; }
    }
}
