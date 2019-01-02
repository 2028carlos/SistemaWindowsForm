
using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
namespace Delaval.sis.Dao
{
  public  class Conexion
    {
        MySqlConnection cn;
        string cadena = "server=localhost;user id=root;database=DB_DELAVAL;pwd=mysql";

        public MySqlConnection abrirConexion()
        {
            try
            {
                cn = new MySqlConnection(cadena);
                if (cn.State == ConnectionState.Closed)
                {
                    cn.Open();
                }
                else
                {
                    cn.Close();
                }
            }
            catch (Exception)
            {

                throw;
            }

            return cn;
        }
    }
}