using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DDL.Servicios;

namespace DDL.Dominio
{
    public class Clientes
    {
        public int id_cliente { get; set; }
        public Tipo_cliente tipos_cliente { get; set; }
        public Tipo_identificacion tipos_Identificacion { get; set; }
        public int identificacion { get; set; }
        public string nombre_raz_social { get; set; }
        public string Direccion { get; set; }
        public Barrio barrio { get; set; }

        public Clientes()
        {
            id_cliente = 0;
            tipos_cliente = (Tipo_cliente)ModeloFactory.ObtenerInstancia().CreaObjeto("tipo_cliente");
            tipos_Identificacion = (Tipo_identificacion)ModeloFactory.ObtenerInstancia().CreaObjeto("tipo_identificacion");
            identificacion = 0;
            nombre_raz_social = string.Empty;
            Direccion = string.Empty;
            barrio = (Barrio)ModeloFactory.ObtenerInstancia().CreaObjeto("barrio");
        }

        public Clientes(string tipoCliente, string tipoIdentificacion, int identificacion, string nombre, string direccion, string nombreBarrio)
        {
            tipos_cliente = (Tipo_cliente)ModeloFactory.ObtenerInstancia().CreaObjeto(tipoCliente);
            tipos_Identificacion = (Tipo_identificacion)ModeloFactory.ObtenerInstancia().CreaObjeto(tipoIdentificacion);
            this.identificacion = identificacion;
            nombre_raz_social = nombre;
            Direccion = direccion;
            barrio = (Barrio)ModeloFactory.ObtenerInstancia().CreaObjeto(nombreBarrio);
        }

        public override string ToString()
        {
            return id_cliente + " - " + nombre_raz_social;
        }
    }
}
