using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2.Back.Models
{
    public class Punctuations
    {
        public int Id { get; set; }  // Identificador único
        public int? userIdJuryman { get; set; }  // ID del jurado (nullable)
        public int? userIdSkin { get; set; }  // ID de la persona evaluada (nullable)
        public int? punctuationValue { get; set; }  // Valor de la puntuación (nullable)
    }
}
