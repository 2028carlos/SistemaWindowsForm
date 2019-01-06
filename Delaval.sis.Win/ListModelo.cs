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
    public partial class ListModelo : Form
    {

        //Delegados
        public delegate void pasarModelo(ModeloEntity c);
        //Evento
        public event pasarModelo pasado;


        ModeloService md = new ModeloService();
        List<ModeloEntity> lista;
        ModeloEntity me;
        public ListModelo()
        {
            InitializeComponent();
        }


        //LISTAR Y FILTRAR
        public void listarModelo(int op)
        {
            //Lista
            lista = new List<ModeloEntity>();
            if (op == 0)
            {
                lista = md.listarModelos();
            }
            else
            {
                //Busca por descripcion
                me = new ModeloEntity();
                me.NombreModelo = txtFiltroModelo.Text;

                lista = null;
                lista = md.listarModeloXNombre(me);

            }


        }

        //LLENAR GRID
        public void llenarGridModelo()
        {


            this.dgModelo.DataSource = null;
            this.dgModelo.Rows.Clear();


            foreach (var item in lista)
            {


                int renglon = this.dgModelo.Rows.Add();
                dgModelo.Rows[renglon].Cells[0].Value = item.idModelos.ToString();
                dgModelo.Rows[renglon].Cells[1].Value = item.NombreModelo.ToString();


            }
        }



        private void ListModelo_Load(object sender, EventArgs e)
        {
            listarModelo(0);
            llenarGridModelo();

        }

        private void btnFiltroModelo_Click(object sender, EventArgs e)
        {
            listarModelo(1);
            llenarGridModelo();

        }

        private void txtFiltroModelo_TextChanged(object sender, EventArgs e)
        {
            btnFiltroModelo.PerformClick();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            ModeloEntity c = new ModeloEntity();
            try
            {
                if (dgModelo.Rows.Count > 0)
                {
                    c.idModelos = dgModelo.CurrentRow.Cells[0].Value.ToString();
                    c.NombreModelo = dgModelo.CurrentRow.Cells[1].Value.ToString();




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
