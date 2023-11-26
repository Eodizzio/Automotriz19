using DDL.Datos.Helper;
using DDL.Datos.Interfaces;
using DDL.Dominio;
using DDL.Servicios;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace DDL.Datos.Implementación
{
    public class DaoHash
    {
        public string HashPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            }
        }

        public bool VerifySPass(string password, string passwordBD)
        {
            string hashedPassword = HashPassword(password);
            return string.Equals(hashedPassword, passwordBD, StringComparison.OrdinalIgnoreCase);
        }

        public bool VerifyPassword(string password, string usuario)
        {
            DataTable nueva_tabla = HelperDB.ObtenerInstancia().CargarTabla("SP_TRAER_USUARIOS");
            foreach (DataRow fila in nueva_tabla.Rows)
            {
                string user = fila["usuario"].ToString();
                string passwordBD = fila["password"].ToString();
                if (VerifySPass(password, passwordBD) && user == usuario)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
