using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DDL.Servicios;

namespace DDL.Dominio
{
    public class Barrio
    {
        public int id_barrio { get; set; }
        public string nom_barrio { get; set; }
        public Provincia provincia { get; set; }

        public Barrio()
        {
            id_barrio = 0;
            nom_barrio = string.Empty;
            provincia = (Provincia)ModeloFactory.ObtenerInstancia().CreaObjeto("provincia");
        }

        public override string ToString()
        {
            return nom_barrio;
        }
    }
}
