using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DDL.Dominio
{
    public class Colores
    {
        public int id_color { get; set; }
        public string color { get; set; }

        public Colores()
        {
            id_color = 0;
            color = string.Empty;
        }

        public override string ToString()
        {
            return color;
        }
    }
}
