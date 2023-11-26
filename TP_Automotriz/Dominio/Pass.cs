using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDL.Dominio
{
    public class Pass
    {
        public string Name { get; set; }
        public string pass { get; set; }

        public Pass()
        {
            Name = string.Empty;
            pass = string.Empty;
        }
    }
}
