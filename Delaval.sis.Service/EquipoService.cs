using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Delaval.sis.Dao;
using Delaval.sis.Entity;
namespace Delaval.sis.Service
{
   public class EquipoService
    {
        EquipoDAO ed = new EquipoDAO();
        public List<EquipoEntity> listarEquipo(){
            return ed.listarEquipo();
        }

        public int InsertandUpdateEquipo(EquipoEntity c, int op)
        {
            return ed.InsertandUpdateEquipo(c, op);
        }
    }
}
