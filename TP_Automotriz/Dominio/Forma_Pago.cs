using DDL.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDL.Dominio
{
    public class Forma_Pago
    {
        public int id_forma_pago { get; set; }
        public string forma_pago { get; set; }

        public Forma_Pago()
        {
            id_forma_pago = 0;
            forma_pago = string.Empty;
        }

        public override string ToString()
        {
            return forma_pago;
        }
    }
}
