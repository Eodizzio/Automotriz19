using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DDL.Servicios;

namespace DDL.Dominio
{
    public class Provincia
    {
        public int id_provincia { get; set; }
        public string provincia { get; set; }
        public Pais pais { get; set; }

        public Provincia()
        {
            id_provincia = 0;
            provincia = string.Empty;
            pais = (Pais)ModeloFactory.ObtenerInstancia().CreaObjeto("pais");
        }

    }
}
