using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDL.Dominio
{
    public class Marca
    {
        public int id_marca { get; set; }
        public string marca { get; set; }

        public Marca()
        {
            id_marca = 0;
            marca = string.Empty;
        }

        public override string ToString()
        {
            return marca;
        }
    }
}
