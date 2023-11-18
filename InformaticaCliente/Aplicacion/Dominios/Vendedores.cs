using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tiendainformatica.Entidades
{
    public class Vendedores
    {
        public int Id_vendedor { get; set; }
        public string NombreVendedor { get; set; }
        public string ApellidoVendedor { get; set; }
        public int num_doc { get; set; }
        public int ID_Tipo_Doc { get; set; }
        public int Id_Contacto { get; set; }
        public Vendedores(int id_vendedor, string nombreVendedor, string apellidoVendedor, int num_doc, int iD_Tipo_Doc, int id_Contacto)
        {
            Id_vendedor = id_vendedor;
            NombreVendedor = nombreVendedor;
            ApellidoVendedor = apellidoVendedor;
            this.num_doc = num_doc;
            ID_Tipo_Doc = iD_Tipo_Doc;
            Id_Contacto = id_Contacto;
        }
    }
}
