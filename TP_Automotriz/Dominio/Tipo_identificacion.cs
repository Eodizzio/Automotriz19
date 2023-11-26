using DDL.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDL.Dominio
{
    public class Tipo_identificacion
    {
        public int id_tipo_identificacion { get; set; }
        public string tipo_identificacion { get; set; }

        public Tipo_identificacion()
        {
            id_tipo_identificacion = 0;
            tipo_identificacion = string.Empty;
        }

        public override string ToString()
        {
            return tipo_identificacion;
        }

    }
}
