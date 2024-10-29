using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2.Back.Models
{
    public class StopsSweet
    {
        public int Id { get; set; }  // Identificador único
        public string sweetType { get; set; }  // Tipo de dulce
        public int? sweetQuantity { get; set; }  // Cantidad de dulces (nullable)
        public int? stopId { get; set; }  // ID de la parada (nullable)
    }
}
