using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using Delaval.sis.Entity;
namespace Delaval.sis.Dao
{
 public   class EquipoDAO
    {
        Conexion cn = new Conexion();

        MySqlCommand cmdCliente;
        MySqlDataReader lector;


        public List<EquipoEntity> listarEquipo()
        {
            List<EquipoEntity> lista = new List<EquipoEntity>();
            EquipoEntity p;
           
            try
            {
                cmdCliente = new MySqlCommand("sp_equipo_List");
                cmdCliente.CommandType = CommandType.StoredProcedure;
             
                cmdCliente.Connection = cn.abrirConexion();

                lector = cmdCliente.ExecuteReader();
                while (lector.Read())
                {
                    p = new EquipoEntity();
                   
                    p.idEquipo = Convert.ToInt32(lector[0]);
                    p.nombre = lector[1].ToString();
                   


                    
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
