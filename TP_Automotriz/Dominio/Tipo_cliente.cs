using DDL.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDL.Dominio
{
    public class Tipo_cliente
    {
        public int id_tipo_cliente { get; set; }
        public string tipo_cliente { get; set; }

        public Tipo_cliente()
        {
            id_tipo_cliente = 0;
            tipo_cliente = string.Empty;
        }

        public override string ToString()
        {
            return tipo_cliente;
        }
    }
}
