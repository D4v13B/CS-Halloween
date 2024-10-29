using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2.Back.Models
{
    public class Stop
    {
        public int id { get; set; }  // Identificador único
        public string name { get; set; }  // Nombre de la parada
        public int? sweetInitialQuantity { get; set; }  // Cantidad inicial de dulces (nullable)
        public int? sweetActualQuantity { get; set; }
    }
}
