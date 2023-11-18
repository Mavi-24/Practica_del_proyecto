using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tiendainformatica.Entidades
{
    public class Detalles_Facturas
    {
        public int Id_Detalle_Factura { get; set; }

        public int Nro_Factura { get; set; }

        public double Pre_Unitario { get; set; }

        public int Cantidad { get; set; }

        public int Id_Producto { get; set; }

        public int Id_Garantia { get; set; }
        public Detalles_Facturas(int id_Detalle_Factura, int nro_Factura, double pre_Unitario, int cantidad, int id_Producto, int id_Garantia)
        {
            Id_Detalle_Factura = id_Detalle_Factura;
            Nro_Factura = nro_Factura;
            Pre_Unitario = pre_Unitario;
            Cantidad = cantidad;
            Id_Producto = id_Producto;
            Id_Garantia = id_Garantia;
        }


    }
}
