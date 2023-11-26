using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DDL.Datos.Helper
{
    public class HelperDB
    {
        private static SqlConnection cnn;
        private static string cnnStringg = @"Data Source=localhost;Initial Catalog=Automotriz_tp;Integrated Security=True";
        SqlCommand comando;
        SqlConnection conexion;

        private static HelperDB? instancia;

        private HelperDB()
        {
            cnn = new SqlConnection(cnnStringg);
            conexion = new SqlConnection(cnnStringg);
            comando = new SqlCommand();
            comando.Connection = conexion;
        }

        public static HelperDB ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new HelperDB();
            }
            return instancia;
        }

        public DataTable ConsultaSQL(string spNombre, List<SqlParameter> values)
        {
            DataTable tabla = new DataTable();

            cnn.Open();
            SqlCommand cmd = new SqlCommand(spNombre, cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            if (values != null)
            {
                foreach (SqlParameter param in values)
                {
                    cmd.Parameters.AddWithValue(param.ParameterName, param.Value);
                }
            }
            tabla.Load(cmd.ExecuteReader());

            cnn.Close();

            return tabla;
        }
        public int EjecutarSQL(string strSql, List<SqlParameter> values)
        {
            int afectadas = 0;
            SqlTransaction t = null;

            try
            {
                cnn.Open();
                t = cnn.BeginTransaction();
                SqlCommand cmd = new SqlCommand(strSql, cnn, t);
                cmd.CommandType = CommandType.StoredProcedure;


                if (values != null)
                {
                    foreach (SqlParameter param in values)
                    {
                        cmd.Parameters.AddWithValue(param.ParameterName, param.Value);
                    }
                }

                afectadas = cmd.ExecuteNonQuery();
                t.Commit();
            }
            catch (SqlException)
            {
                if (t != null) { t.Rollback(); }
            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }

            return afectadas;
        }

        public int ConsultaEscalarSQL(string spNombre, string pOutNombre)
        {
            cnn.Open();
            SqlCommand cmd = new SqlCommand(spNombre, cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter pOut = new SqlParameter();
            pOut.ParameterName = pOutNombre;
            pOut.DbType = DbType.Int32;
            pOut.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(pOut);
            cmd.ExecuteNonQuery();
            cnn.Close();

            return (int)pOut.Value;
        }

        public SqlConnection ObtenerConexion()
        {
            return cnn;
        }

        public void AbreConexionConTransaccion()
        {
            try
            {
                conexion.Open();
                comando.Transaction = conexion.BeginTransaction();
            }
            catch (SqlException ex)
            {
                if (comando.Transaction != null)
                    comando.Transaction.Rollback();
                if (conexion != null && conexion.State == ConnectionState.Open)
                    conexion.Close();
                throw ex;
            }
        }

        public void CierraConexionConTransaccion()
        {
            try
            {
                comando.Transaction.Commit();
                conexion.Close();
            }
            catch (SqlException ex)
            {
                if (comando.Transaction != null)
                    comando.Transaction.Rollback();
                if (conexion != null && conexion.State == ConnectionState.Open)
                    conexion.Close();
                throw ex;
            }
        }

        public DataTable CargarTabla(string SP, List<SqlParameter>? lista_parametros = null)
        {
            try
            {
                DataTable Tabla = new DataTable();
                while (conexion.State != ConnectionState.Closed) { }
                conexion.Open();
                comando.CommandText = SP;
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Clear();
                if (lista_parametros != null)
                {
                    foreach (SqlParameter param in lista_parametros)
                    {
                        comando.Parameters.Add(param);
                    }
                }
                Tabla.Load(comando.ExecuteReader());
                conexion.Close();
                return Tabla;
            }
            catch (SqlException ex)
            {
                if (conexion != null && conexion.State == ConnectionState.Open)
                    conexion.Close();
                throw ex;
            }
        }

        public DataTable CargarTablaEnTransaccion(string SP, List<SqlParameter>? lista_parametros = null)
        {
            try
            {
                DataTable Tabla = new DataTable();
                comando.CommandText = SP;
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Clear();
                if (lista_parametros != null)
                {
                    foreach (SqlParameter param in lista_parametros)
                    {
                        comando.Parameters.Add(param);
                    }
                }
                Tabla.Load(comando.ExecuteReader());
                return Tabla;
            }
            catch (SqlException ex)
            {
                if (conexion != null && conexion.State == ConnectionState.Open)
                    conexion.Close();
                throw ex;
            }
        }

        public int EjecutaComando(string SP, List<SqlParameter> lista_param, SqlParameter? salida)
        {
            try
            {
                int resultado = -1;
                comando.Parameters.Clear();
                comando.CommandText = SP;
                comando.CommandType = CommandType.StoredProcedure;
                if (salida != null)
                    comando.Parameters.Add(salida);
                foreach (SqlParameter param in lista_param)
                    comando.Parameters.Add(param);
                comando.ExecuteNonQuery();
                if (salida != null)
                    resultado = (int)salida.Value;
                else
                    resultado = 0;
                return resultado;
            }
            catch (SqlException ex)
            {
                if (comando.Transaction != null)
                    comando.Transaction.Rollback();
                if (conexion != null && conexion.State == ConnectionState.Open)
                    conexion.Close();
                throw ex;
            }
        }


    }
}
