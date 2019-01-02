using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delaval.sis.Entity
{
 public  class ArticuloEntity
    {

        public int idArticuloc { get; set; }
        public int codigo { get; set; }
        public string descripcion { get; set; }
        public  string unidadmedida { get; set; }
        public int unidad { get; set; }
        public string programa { get; set; }
        public decimal precio { get; set; }

        public int Equipo { get; set; }
        public int Modelo { get; set; }
    }
}
