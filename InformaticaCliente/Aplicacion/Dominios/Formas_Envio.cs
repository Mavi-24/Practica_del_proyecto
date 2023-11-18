using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tiendainformatica.Entidades
{
    public class Formas_Envio
    {
        public int Id_Forma_Envio { get; set; }

        public string Descripcion { get; set; }
        public Formas_Envio(int id_Forma_Envio, string descripcion)
        {
            Id_Forma_Envio = id_Forma_Envio;
            Descripcion = descripcion;
        }

    }
}
