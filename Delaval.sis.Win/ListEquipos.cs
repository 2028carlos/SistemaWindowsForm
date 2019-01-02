using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Delaval.sis.Entity;
using Delaval.sis.Service;
namespace Delaval.sis.Win
{
    public partial class ListEquipos : Form
    {
        EquipoService es = new EquipoService();
        List<EquipoEntity> lista;
        public void listadoEquipo()
        {
            lista = new List<EquipoEntity>();
            lista = es.listarEquipo();

            this.dgEquipo.DataSource = null;
            this.dgEquipo.Rows.Clear();


            foreach (var item in lista)
            {


                int renglon = this.dgEquipo.Rows.Add();
                dgEquipo.Rows[renglon].Cells[0].Value = item.idEquipo.ToString();
                dgEquipo.Rows[renglon].Cells[1].Value = item.nombre.ToString();
               

            }
        }
        public ListEquipos()
        {
            InitializeComponent();
     
        }

        private void ListEquipos_Load(object sender, EventArgs e)
        {
            listadoEquipo();
        }
    }
}
