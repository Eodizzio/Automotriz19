using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDL.Datos.Interfaces
{
    internal interface IObjsDAO
    {
        int InsertarRegistro(object objeto);
        List<KeyValuePair<int, string>> ListaSimpleRegistros();
        object BuscaRegistro(int registro);
        int ModificarRegistro(object objeto);
        int EliminarRegistro(int codigo);
    }
}
