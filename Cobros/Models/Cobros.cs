using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cobros.Models
{
    public class Cobros
    {
        public int CobroId { get; set; }
        public string Fecha { get; set; }
        public string Referencia { get; set; }
        public int IdRemoto { get; set; }
        public int idRuta { get; set; }
        public double Mora { get; set; }
        public double Monto { get; set; }
        public int Latitud { get; set; }
        public int Longitud { get; set; }
        public bool EsNulo { get; set; }
    }
}