using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDL.Dominio
{
    public class Tipo_producto
    {
        public int id_tipo_producto { get; set; }
        public string tipo_producto { get; set; }

        public Tipo_producto()
        {
            id_tipo_producto = 1;
            tipo_producto = "Automóvil";
        }

        public override string ToString()
        {
            return tipo_producto;
        }
    }
}
