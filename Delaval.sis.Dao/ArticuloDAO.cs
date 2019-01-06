
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Delaval.sis.Entity;
using MySql.Data.MySqlClient;
using System.Data;

namespace Delaval.sis.Dao
{
   public  class ArticuloDAO
    {
        Conexion cn = new Conexion();

        MySqlCommand cmdCliente;
        MySqlDataReader lector;

        //Lista


        public List<ArticuloEntity> listarArticulo()
        {
            List<ArticuloEntity> lista = new List<ArticuloEntity>();
            ArticuloEntity p;
            ModeloEntity or;
            EquipoEntity le;
            try
            {
                cmdCliente = new MySqlCommand("sp_articulo_list");
                cmdCliente.CommandType = CommandType.StoredProcedure;
                cmdCliente.Connection = cn.abrirConexion();

                lector = cmdCliente.ExecuteReader();
                while (lector.Read())
                {
                    p = new ArticuloEntity();
                    or = new ModeloEntity();
                    le = new EquipoEntity();
                    p.idArticulo = lector[0].ToString();
                    p.codigo = Convert.ToInt32(lector[1]) ;
                    p.descripcion = lector[2].ToString();
                    p.unidadmedida = lector[3].ToString();

                    p.unidad = Convert.ToInt32(lector[4]); 
                    p.programa = lector[5].ToString();
                    p.precio = Convert.ToDecimal(lector[6]); 
                    le.nombre = lector[7].ToString();
                    p.Equipo = le;

                    or.NombreModelo = lector[8].ToString();
                    p.Modelo = or;


                    lista.Add(p);
                }
            }
            catch (Exception)
            {

                throw;
            }
            return lista;
        }
        ////Buscar por descripcion
        public List<ArticuloEntity> listarArticulosXdescripcion(ArticuloEntity c)
        {
            List<ArticuloEntity> lista = new List<ArticuloEntity>();

            ArticuloEntity p;
            ModeloEntity or;
            EquipoEntity le;
            try
            {
                cmdCliente = new MySqlCommand("sp_articulo_filtrarbydescripcion");
                cmdCliente.CommandType = CommandType.StoredProcedure;
                cmdCliente.Connection = cn.abrirConexion();
                cmdCliente.Parameters.AddWithValue("des", c.descripcion);
              

                lector = cmdCliente.ExecuteReader();



                while (lector.Read())
                {



                   
                    p = new ArticuloEntity();
                    or = new ModeloEntity();
                    le = new EquipoEntity();
                    p.idArticulo = lector[0].ToString();
                    p.codigo = Convert.ToInt32(lector[1]); 
                    p.descripcion = lector[2].ToString();
                    p.unidadmedida = lector[3].ToString();

                    p.unidad = Convert.ToInt32(lector[4]);
                    p.programa = lector[5].ToString();
                    p.precio = Convert.ToDecimal(lector[6].ToString());
                    le.nombre = lector[7].ToString();
                    p.Equipo = le;

                    or.NombreModelo = lector[8].ToString();
                    p.Modelo = or;
                    lista.Add(p);
                }
            }
            catch (Exception)
            {

                //MessageBox.Show("Busqueda Invalida", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return lista;
        }

        //// Busca por dni
        //public List<PersonEntity> BuscaXDni(PersonEntity c)
        //{
        //    List<PersonEntity> lista = new List<PersonEntity>();

        //    PersonEntity p;
        //    origenEntity or;
        //    levelEntity le;
        //    try
        //    {
        //        cmdCliente = new MySqlCommand("sp_person_buscaXDni");
        //        cmdCliente.CommandType = CommandType.StoredProcedure;
        //        cmdCliente.Connection = cn.abrirConexion();
        //        cmdCliente.Parameters.AddWithValue("doc", c.dni);

        //        lector = cmdCliente.ExecuteReader();
        //        while (lector.Read())
        //        {

        //            p = new PersonEntity();
        //            or = new origenEntity();
        //            le = new levelEntity();
        //            p.personid = lector[0].ToString();
        //            p.name = lector[1].ToString();
        //            p.lastname = lector[2].ToString();

        //            p.birthdate = lector[3].ToString();
        //            p.dni = lector[4].ToString();
        //            p.occupation = lector[5].ToString();


        //            p.address = lector[6].ToString();
        //            p.phone = lector[7].ToString();
        //            p.cellphone = lector[8].ToString();
        //            p.email = lector[9].ToString();
        //            p.promotion = lector[10].ToString();
        //            p.contract = lector[11].ToString();
        //            p.e_avanzado = lector[12].ToString();
        //            p.e_firstweekend = lector[13].ToString();
        //            p.e_secondweekend = lector[14].ToString();
        //            p.observations = lector[15].ToString();

        //            le.names = lector[16].ToString();
        //            p.levelid = le;
        //            or.name = lector[17].ToString();
        //            p.origenid = or;
        //            p.enroladoId = Convert.ToInt32(lector[18]);
        //            p.promotionenrolador = lector[19].ToString();
        //            lista.Add(p);
        //        }
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //    return lista;
        //}

        public int InsertandUpdateArticulo(ArticuloEntity c, int op)
        {
            string sql = "sp_articulos_add";
            if (op == 1)
            {
                sql = "sp_articulo_update";
            }
            int valor = 0;

            cmdCliente = new MySqlCommand();
            cmdCliente.CommandType = CommandType.StoredProcedure;
            cmdCliente.CommandText = sql;
            cmdCliente.Connection = cn.abrirConexion();

            cmdCliente.Parameters.AddWithValue("id", c.idArticulo);
            cmdCliente.Parameters.AddWithValue("cod", c.codigo );
            cmdCliente.Parameters.AddWithValue("des", c.descripcion  ?? "");
            cmdCliente.Parameters.AddWithValue("unimed", c.unidadmedida ?? "" );
            cmdCliente.Parameters.AddWithValue("uni", c.unidad  );
            cmdCliente.Parameters.AddWithValue("progra", c.programa ?? "" );
            cmdCliente.Parameters.AddWithValue("precio", c.precio );
            cmdCliente.Parameters.AddWithValue("idEqu", c.Equipo.nombre );
            cmdCliente.Parameters.AddWithValue("idMod", c.Modelo.NombreModelo );
           
            


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

        //public int PersonDelete(PersonEntity c)
        //{
        //    try
        //    {
        //        cmdCliente = new MySqlCommand("sp_person_delete");
        //        cmdCliente.CommandType = CommandType.StoredProcedure;
        //        cmdCliente.Connection = cn.abrirConexion();
        //        cmdCliente.Parameters.AddWithValue("id", c.personid);

        //        int i = cmdCliente.ExecuteNonQuery();
        //        if (i > 0)
        //        {
        //            return 1;
        //        }
        //        else
        //        {
        //            return 0;
        //        }

        //    }

        //    catch (Exception)
        //    {

        //        throw;

        //    }

        //}




    }
}
