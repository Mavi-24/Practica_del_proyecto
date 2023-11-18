using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tiendainformatica.Entidades
{
    public class Facturas
    {
        public int Nro_Factura { get; set; }

        public DateTime Fecha { get; set; }

        public int Id_vendedor { get; set; }

        public int Id_Cliente { get; set; }

        public int Id_Forma_Envio { get; set; }

        public int Id_Forma_Pago { get; set; }
        public Facturas(int nro_Factura, DateTime fecha, int id_vendedor, int id_Cliente, int id_Forma_Envio, int id_Forma_Pago)
        {
            Nro_Factura = nro_Factura;
            Fecha = fecha;
            Id_vendedor = id_vendedor;
            Id_Cliente = id_Cliente;
            Id_Forma_Envio = id_Forma_Envio;
            Id_Forma_Pago = id_Forma_Pago;
        }


    }
}
