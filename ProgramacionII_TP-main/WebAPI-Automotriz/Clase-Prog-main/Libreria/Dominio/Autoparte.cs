using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.Dominio
{
    public class Autoparte
    {
        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public int Modelo { get; set; }
        public int TipoVehiculo { get; set; }
        public double Precio { get; set; }
    }
}
