using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.Dominio
{
    public class TipoEmpleado
    {
        public int Codigo { get; set; }
        public string Descripcion { get; set; }

        public TipoEmpleado(int codigo, string tipo)
        {
            Codigo = codigo;
            Descripcion = tipo;
        }
    }
}
