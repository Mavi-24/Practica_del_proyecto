using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.Dominio
{
    public class Modelo
    {
        public int Codigo { get; set; }
        public string Descripcion { get; set; }

        public Modelo(int cod, string desc)
        {
            Codigo = cod;
            Descripcion = desc;
        }
    }
}
