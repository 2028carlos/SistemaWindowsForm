using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Delaval.sis.Entity;
using MySql.Data.MySqlClient;

namespace Delaval.sis.Dao
{
    public class ModeloDAO
    {
        Conexion cn = new Conexion();

        MySqlCommand cmdCliente;
        MySqlDataReader lector;


        public List<ModeloEntity> listarModelos()
        {
            List<ModeloEntity> lista = new List<ModeloEntity>();
            ModeloEntity p;

            try
            {
                cmdCliente = new MySqlCommand("sp_modelo_list");
                cmdCliente.CommandType = CommandType.StoredProcedure;

                cmdCliente.Connection = cn.abrirConexion();

                lector = cmdCliente.ExecuteReader();
                while (lector.Read())
                {
                    p = new ModeloEntity();

                    p.idModelos= Convert.ToInt32(lector[0]);
                    p.NombreModelo = lector[1].ToString();




                    lista.Add(p);
                }
            }
            catch (Exception)
            {

                throw;
            }
            return lista;
        }



    }
}
