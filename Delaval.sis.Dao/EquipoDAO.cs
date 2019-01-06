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
                   
                    p.idEquipo = lector[0].ToString();
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


        //buscar por nombre 
     
        public List<EquipoEntity> listarEquipoXNombre(EquipoEntity c)
        {
            List<EquipoEntity> lista = new List<EquipoEntity>();

            EquipoEntity p;
          
            try
            {
                cmdCliente = new MySqlCommand("sp_equipo_filtarbyName");
                cmdCliente.CommandType = CommandType.StoredProcedure;
                cmdCliente.Connection = cn.abrirConexion();
                cmdCliente.Parameters.AddWithValue("name", c.nombre);


                lector = cmdCliente.ExecuteReader();



                while (lector.Read())
                {




                    p = new EquipoEntity();
                   
                    p.idEquipo = lector[0].ToString();
                    p.nombre = lector[1].ToString();
                  

                   
                    lista.Add(p);
                }
            }
            catch (Exception)
            {

                //MessageBox.Show("Busqueda Invalida", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return lista;
        }



        //GUARDAR DATOS
        public int InsertandUpdateEquipo(EquipoEntity c, int op)
        {
            string sql = "sp_equipo_add";
            if (op == 1)
            {
                sql = "sp_equipo_update";
            }
            int valor = 0;

            cmdCliente = new MySqlCommand();
            cmdCliente.CommandType = CommandType.StoredProcedure;
            cmdCliente.CommandText = sql;
            cmdCliente.Connection = cn.abrirConexion();

            cmdCliente.Parameters.AddWithValue("id", c.idEquipo);
            cmdCliente.Parameters.AddWithValue("name", c.nombre ?? "");
          




            int i = cmdCliente.ExecuteNonQuery();
            if (i > 0)
            {
                valor = 1;
            }
            else
            {
                valor = 0;
            }
            cmdCliente.Parameters.Clear();
            return valor;
        }

    }
}
