using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tiendainformatica.Entidades
{
    public class Productos
    {
        public int Id_Producto { get; set; }
        public double Pre_Unitario { get; set; }
        public string Descripcion { get; set; }
        public string Link_image { get; set; }
        public int Id_Marca { get; set; }
        public int Id_tipo_Producto { get; set; }
        public Productos(int id_Producto, double pre_Unitario, string descripcion, string link_image, int id_Marca, int id_tipo_Producto)
        {
            Id_Producto = id_Producto;
            Pre_Unitario = pre_Unitario;
            Descripcion = descripcion;
            Link_image = link_image;
            Id_Marca = id_Marca;
            Id_tipo_Producto = id_tipo_Producto;
        }
    }
}
