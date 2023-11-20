using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Libreria.Dominio
{
    public class DetalleFactura
    {
        //public Producto Producto { get; set; }
        public int CodProducto { get; set; }
        public int Cantidad { get; set; }
        public double Precio { get; set; }
        public string? Descripcion { get; set; }

        public DetalleFactura()
        {

        }
 
        public DetalleFactura(int cod, int cant) 
        {
            CodProducto = cod;
            Cantidad= cant;
        }

        public double CalcularSubTotal() 
        {
            return Precio * Cantidad;
        }
    }
}
