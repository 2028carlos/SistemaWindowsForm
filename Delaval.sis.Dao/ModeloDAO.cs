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

                    p.idModelos= lector[0].ToString();
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


        //buscar por nombre 

        public List<ModeloEntity> listarModeloXNombre(ModeloEntity c)
        {
            List<ModeloEntity> lista = new List<ModeloEntity>();

            ModeloEntity p;

            try
            {
                cmdCliente = new MySqlCommand("sp_modelofiltrabyNombre");
                cmdCliente.CommandType = CommandType.StoredProcedure;
                cmdCliente.Connection = cn.abrirConexion();
                cmdCliente.Parameters.AddWithValue("name", c.NombreModelo);


                lector = cmdCliente.ExecuteReader();



                while (lector.Read())
                {




                    p = new ModeloEntity();

                    p.idModelos = lector[0].ToString();
                    p.NombreModelo = lector[1].ToString();



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
        public int InsertandUpdateModelo(ModeloEntity c, int op)
        {
            string sql = "sp_modelo_add";
            if (op == 1)
            {
                sql = "sp_modelo_update";
            }
            int valor = 0;

            cmdCliente = new MySqlCommand();
            cmdCliente.CommandType = CommandType.StoredProcedure;
            cmdCliente.CommandText = sql;
            cmdCliente.Connection = cn.abrirConexion();

            cmdCliente.Parameters.AddWithValue("id", c.idModelos);
            cmdCliente.Parameters.AddWithValue("name", c.NombreModelo ?? "");





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


        //LISTAR MODELOS POR EQUIPO
        public List<ModeloEntity> listarporEquipo(int equipo)
        {
            List<ModeloEntity> lista = new List<ModeloEntity>();

            ModeloEntity p;
           
            
            try
            {
                cmdCliente = new MySqlCommand("sp_modelobyEquipo");
                cmdCliente.CommandType = CommandType.StoredProcedure;
                cmdCliente.Connection = cn.abrirConexion();
                cmdCliente.Parameters.AddWithValue("equipo", equipo);
              

                lector = cmdCliente.ExecuteReader();

                while (lector.Read())
                {
                    p = new ModeloEntity();

                    p.idModelos = lector[0].ToString();
                    p.NombreModelo = lector[1].ToString();
                    lista.Add(p);
                }
            }
            catch (Exception)
            {

                //MessageBox.Show("Busqueda Invalida", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return lista;
        }




    }
}
