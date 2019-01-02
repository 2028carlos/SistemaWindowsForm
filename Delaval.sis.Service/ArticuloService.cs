using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Delaval.sis.Dao;
using Delaval.sis.Entity;
namespace Delaval.sis.Service
{
   public class ArticuloService
    {
        ArticuloDAO ar = new ArticuloDAO();
        public int InsertandUpdateAriculo(ArticuloEntity c, int op)
        {
            return ar.InsertandUpdateArticulo(c,op);
        }

    }
}
