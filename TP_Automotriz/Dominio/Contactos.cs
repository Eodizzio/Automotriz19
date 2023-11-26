using DDL.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDL.Dominio
{
    public class Contactos
    {
        public int id_contacto { get; set; }
        public Clientes cliente { get; set; }
        public Tipo_contacto tipo_contacto { get; set; }
        public string contacto { get; set; }



        public Contactos()
        {
            id_contacto = 0;
            cliente = (Clientes)ModeloFactory.ObtenerInstancia().CreaObjeto("cliente");
            tipo_contacto = (Tipo_contacto)ModeloFactory.ObtenerInstancia().CreaObjeto("tipo_contacto");
            contacto = string.Empty;
        }

    }
}
