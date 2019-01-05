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
    }
}
