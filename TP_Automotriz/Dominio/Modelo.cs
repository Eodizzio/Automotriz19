using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DDL.Dominio
{
    public class Modelo
    {
        public int id_modelo { get; set; }
        public string modelo { get; set; }

        public Modelo()
        {
            id_modelo = 0;
            modelo = string.Empty;
        }

        public override string ToString()
        {
            return modelo;
        }
    }
}
