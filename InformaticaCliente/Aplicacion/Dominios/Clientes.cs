using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tiendainformatica.Entidades
{
    public class Clientes
    {
        public int ID_cliente { get; set; }
        public string NombreCliente { get; set; }
        public string ApellidoCliente { get; set; }
        public int num_doc { get; set; }
        public int Id_tipo_doc { get; set; }
        public int Id_contacto { get; set; }
        public Clientes(int iD_cliente, string nombreCliente, string apellidoCliente, int num_doc, int id_tipo_doc, int id_contacto)
        {
            ID_cliente = iD_cliente;
            NombreCliente = nombreCliente;
            ApellidoCliente = apellidoCliente;
            this.num_doc = num_doc;
            Id_tipo_doc = id_tipo_doc;
            //Id_contacto = id_contacto; no quiero
        }

    }
}
