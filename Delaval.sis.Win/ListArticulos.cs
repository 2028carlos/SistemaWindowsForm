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
    public partial class ListArticulos : Form
    {

        //Delegados
        public delegate void pasar(ArticuloEntity c);
        //Evento
        public event pasar pasado;


        ArticuloService ars = new ArticuloService();
        List<ArticuloEntity> lista;
        ArticuloEntity ar;
        public ListArticulos()
        {
            InitializeComponent();
        }


        //LISTAR Y FILTRAR
        public void listaArticulo(int op)
        {
            //Lista
            lista = new List<ArticuloEntity>();
            if (op == 0)
            {
                lista = ars.listarArticulo();
            }
            else
            {
                //Busca por descripcion
                ar = new ArticuloEntity();
                ar.descripcion = txtFiltar.Text;

                lista = null;
                lista = ars.listarArticulosXdescripcion(ar);

            }


            }


        //LLENAR EL GRID
        public void llenarGrid()
        {


            this.dgArticulos.DataSource = null;
            this.dgArticulos.Rows.Clear();


            foreach (var item in lista)
            {


                int renglon = this.dgArticulos.Rows.Add();

                dgArticulos.Rows[renglon].Cells[0].Value = item.idArticulo.ToString();
                dgArticulos.Rows[renglon].Cells[1].Value = item.codigo.ToString();
                dgArticulos.Rows[renglon].Cells[2].Value = item.descripcion.ToString();
                dgArticulos.Rows[renglon].Cells[3].Value = item.unidadmedida.ToString();
                dgArticulos.Rows[renglon].Cells[4].Value = item.unidad.ToString();
                dgArticulos.Rows[renglon].Cells[5].Value = item.programa.ToString();
                dgArticulos.Rows[renglon].Cells[6].Value = item.precio.ToString();
                dgArticulos.Rows[renglon].Cells[7].Value = item.Equipo.nombre.ToString();
                dgArticulos.Rows[renglon].Cells[8].Value = item.Modelo.NombreModelo.ToString();

            }
        }


        private void ListArticulos_Load(object sender, EventArgs e)
        {
            listaArticulo(0);
            llenarGrid();
        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            listaArticulo(1);
            llenarGrid();
        }

        private void txtFiltar_TextChanged(object sender, EventArgs e)
        {
            btnFiltro.PerformClick();
        }

        private void btnSeleccion_Click(object sender, EventArgs e)
        {
            ArticuloEntity c = new ArticuloEntity();
            try
            {
                if (dgArticulos.Rows.Count > 0)
                {
                    c.idArticulo =dgArticulos.CurrentRow.Cells[0].Value.ToString();
                    c.codigo = Convert.ToInt32(dgArticulos.CurrentRow.Cells[1].Value) ;
                    c.descripcion = dgArticulos.CurrentRow.Cells[2].Value.ToString();
                    c.unidadmedida = dgArticulos.CurrentRow.Cells[3].Value.ToString();

                    c.unidad = Convert.ToInt32(dgArticulos.CurrentRow.Cells[4].Value); 
                    c.programa = dgArticulos.CurrentRow.Cells[5].Value.ToString();
                    c.precio = Convert.ToDecimal(dgArticulos.CurrentRow.Cells[6].Value.ToString()); 
                    EquipoEntity eq = new EquipoEntity();
                    eq.nombre = dgArticulos.CurrentRow.Cells[7].Value.ToString();
                    c.Equipo = eq;

                    ModeloEntity md = new ModeloEntity();
                    md.NombreModelo = dgArticulos.CurrentRow.Cells[8].Value.ToString();
                    c.Modelo = md;
                 
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
