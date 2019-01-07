using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Delaval.sis.Dao;
using Delaval.sis.Entity;
namespace Delaval.sis.Service
{
  public  class ModeloService
    {
        ModeloDAO md = new ModeloDAO();
        public List<ModeloEntity> listarModelos()
        {
            return md.listarModelos();
        }

        public List<ModeloEntity> listarModeloXNombre(ModeloEntity c)
        {
            return md.listarModeloXNombre(c);
        }

        public int InsertandUpdateModelo(ModeloEntity c, int op)
        {
            return md.InsertandUpdateModelo(c, op);
        }

        public List<ModeloEntity> listarporEquipo(int c)
        {
            return md.listarporEquipo(c);
        }
    }
}
