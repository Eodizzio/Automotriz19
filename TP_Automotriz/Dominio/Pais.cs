using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DDL.Dominio
{
    public class Pais
    {
        public int id_pais { get; set; }
        public string pais { get; set; }

        public Pais()
        {
            id_pais = 0;
            pais = string.Empty;
        }

        public override string ToString()
        {
            return pais;
        }
    }
}
