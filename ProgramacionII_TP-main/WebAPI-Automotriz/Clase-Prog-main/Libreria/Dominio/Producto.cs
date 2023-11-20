using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.Dominio
{
    public class Producto
    {
        public int CodProducto { get; set; }
        public int CodTipoProducto { get; set; }
        public string Descripcion { get; set; }
        public int CodModelo { get; set; }
        public int CodTipoVehiculo { get; set; }
        public string Color { get; set; }
        public double Precio { get; set; }
        public DateTime FecFabricacion { get; set; }

        public Producto()
        {

        }

        public Producto(int cod, string desc)
        {
            CodProducto = cod;
            Descripcion = desc;
        }
    }
}
