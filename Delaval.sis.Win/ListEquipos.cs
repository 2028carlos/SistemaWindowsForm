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
        //Delegados
        public delegate void pasarEquipo(EquipoEntity c);
        //Evento
        public event pasarEquipo pasado;




        EquipoService es = new EquipoService();
        List<EquipoEntity> lista;
        EquipoEntity ar;
        //LISTAR Y FILTRAR
        public void listaEquipo(int op)
        {
            //Lista
            lista = new List<EquipoEntity>();
            if (op == 0)
            {
                lista = es.listarEquipo();
            }
            else
            {
                //Busca por descripcion
                ar = new EquipoEntity();
                ar.nombre = txtFiltroEquipo.Text;

                lista = null;
                lista = es.listarEquipoXNombre(ar);

            }


        }












        public void llenarGridEquipo()
        {
          

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
            listaEquipo(0);
            llenarGridEquipo();

        }

        private void btnFiltroEquipo_Click(object sender, EventArgs e)
        {
            listaEquipo(1);
            llenarGridEquipo();
        }

        private void txtFiltroEquipo_TextChanged(object sender, EventArgs e)
        {
            btnFiltroEquipo.PerformClick();
        }

        private void btnSeleccionEquipo_Click(object sender, EventArgs e)
        {
            EquipoEntity c = new EquipoEntity();
            try
            {
                if (dgEquipo.Rows.Count > 0)
                {
                    c.idEquipo = dgEquipo.CurrentRow.Cells[0].Value.ToString();
                    c.nombre = dgEquipo.CurrentRow.Cells[1].Value.ToString();
                   

                

                    pasado(c);
                }


                this.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Error envio de datos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    }
