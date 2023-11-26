using DDL.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDL.Dominio
{
    public class Tipo_movimiento
    {
        public int id_tipo_movimiento { get; set; }
        public string tipo_movimiento { get; set; }

        public Tipo_movimiento()
        {
            id_tipo_movimiento = 0;
            tipo_movimiento = string.Empty;
        }

    }
}
