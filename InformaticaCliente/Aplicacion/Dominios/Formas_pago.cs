using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tiendainformatica.Entidades
{
    public class Formas_pago
    {
        public int Id_Forma_Pago { get; set; }

        public string Descripcion { get; set; }
        public Formas_pago(int id_Forma_Pago, string descripcion)
        {
            Id_Forma_Pago = id_Forma_Pago;
            Descripcion = descripcion;
        }


    }
}
