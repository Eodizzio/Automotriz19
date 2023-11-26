using DDL.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDL.Dominio
{
    public class Tipo_contacto
    {
        public int id_tipo_contacto { get; set; }
        public string tipo_contacto { get; set; }

        public Tipo_contacto()
        {
            id_tipo_contacto = 0;
            tipo_contacto = string.Empty;
        }

    }
}
