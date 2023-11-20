using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.Dominio
{
    public class Factura
    {
        public int CodFactura { get; set; }
        public int CodEmpleado { get; set; }
        public DateTime Fecha { get; set; }
        public string NomCliente { get; set; }
        public long Cuit { get; set; }
        public int CodPlan { get; set; }
        public int CodTipoCliente { get; set; }
        public List<DetalleFactura> Detalles { get; set; }

        public Factura()
        {
            Detalles = new List<DetalleFactura>();
        }

        public void AgregarDetalle(DetalleFactura detalle)
        {
            Detalles.Add(detalle);
        }

        public void QuitarDetalle(int indice)
        {
            Detalles.RemoveAt(indice);
        }

        public double CalcularTotal()
        {
            double total = 0;
            foreach (DetalleFactura item in Detalles)
            {
                total += item.CalcularSubTotal();
            }
            return total;
        }
    }
}
