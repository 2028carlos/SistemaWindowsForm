using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Delaval.sis.Service;
using Delaval.sis.Entity;
using Delaval.sis.Win.Reporte;
using DevExpress.XtraReports.UI;

namespace Delaval.sis.Win
{
    public partial class Filtro : Form
    {
        EquipoService es = new EquipoService();
        ModeloService me = new ModeloService();
        ArticuloService ar = new ArticuloService();

        List<EquipoEntity> listaEquipo;
        List<ModeloEntity> listaModelo;
        List<ArticuloEntity> lista;
        public Filtro()
        {
            InitializeComponent();
        }

        //LISTA COMBO EQUIPO
        public void ListarComboEquipo()
        {
            listaEquipo = new List<EquipoEntity>();
            listaEquipo = es.listarEquipo();
            Dictionary<int, String> dicTemp = new Dictionary<int, string>();

            foreach (var entidad in listaEquipo)
            {

                dicTemp.Add(Convert.ToInt32(entidad.idEquipo), entidad.nombre);

            }

            cboEquipos.DataSource = new BindingSource(dicTemp, null);

            cboEquipos.DisplayMember = "Value";
            cboEquipos.ValueMember = "Key";

        }








        //LISTA COMBO MODELO
        public void ListarComboModelo()
        {

            KeyValuePair<int, string> objeto = (KeyValuePair<int, string>)cboEquipos.SelectedItem;
            int idequipo = objeto.Key;

            listaModelo = new List<ModeloEntity>();
            listaModelo = me.listarporEquipo(idequipo);

            Dictionary<int, String> dicTemp = new Dictionary<int, string>();

            foreach (var entidad in listaModelo)
            {

                dicTemp.Add(Convert.ToInt32(entidad.idModelos), entidad.NombreModelo);

            }

            cboModelo.DataSource = new BindingSource(dicTemp, null);

            cboModelo.DisplayMember = "Value";
            cboModelo.ValueMember = "Key";
        }


        //LISTAR CON COMBOS 
        public void ListarConCombos()
        {
            KeyValuePair<int, string> objeto = (KeyValuePair<int, string>)cboEquipos.SelectedItem;
            int idequipo = objeto.Key;

            KeyValuePair<int, string> objeto1 = (KeyValuePair<int, string>)cboModelo.SelectedItem;
            int modelo = objeto1.Key;


            int pro = Convert.ToInt32(cboProgramacion.Text);

            //Lista
            lista = new List<ArticuloEntity>();

            lista = ar.listarConCombos(idequipo, modelo, pro);



        }




        //LLENAR EL GRID
        public void llenarGrid()
        {


            this.dgArticulos.DataSource = null;
            this.dgArticulos.Rows.Clear();


            foreach (var item in lista)
            {

                int renglon = this.dgArticulos.Rows.Add();

                dgArticulos.Rows[renglon].Cells[1].Value = item.idArticulo.ToString();
                dgArticulos.Rows[renglon].Cells[2].Value = item.codigo.ToString();
                dgArticulos.Rows[renglon].Cells[3].Value = item.descripcion.ToString();
                dgArticulos.Rows[renglon].Cells[4].Value = item.unidadmedida.ToString();
                dgArticulos.Rows[renglon].Cells[5].Value = item.unidad.ToString();
                dgArticulos.Rows[renglon].Cells[6].Value = item.programa.ToString();
                dgArticulos.Rows[renglon].Cells[7].Value = item.precio.ToString();
                dgArticulos.Rows[renglon].Cells[8].Value = item.Equipo.nombre.ToString();
                dgArticulos.Rows[renglon].Cells[9].Value = item.Modelo.NombreModelo.ToString();

            }
        }


        private void Filtro_Load(object sender, EventArgs e)
        {
            ListarComboEquipo();
        }


        private void cboEquipos_SelectedValueChanged(object sender, EventArgs e)
        {
            ListarComboModelo();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ListarConCombos();
            llenarGrid();
        }

        ArticuloEntity art;
        private void btnExportar_Click(object sender, EventArgs e)
        {
            List<ArticuloEntity> newlista = new List<ArticuloEntity>();
            decimal total1 = 0;
            foreach (DataGridViewRow row in dgArticulos.Rows)
            {
                try
                {
                    if (Convert.ToBoolean(row.Cells[0].Value))
                    {
                        art = new ArticuloEntity();
                       
                        art.codigo = Convert.ToInt32(row.Cells[2].Value);
                        art.descripcion = row.Cells[3].Value.ToString();
                        art.unidadmedida = row.Cells[4].Value.ToString();
                        art.unidad = Convert.ToInt32(row.Cells[5].Value);
                        art.programa = row.Cells[6].Value.ToString() ;
                        art.precio = Convert.ToDecimal(row.Cells[7].Value);
                        EquipoEntity eq = new EquipoEntity();
                        eq.nombre= row.Cells[8].Value.ToString();
                        art.Equipo = eq;


                        ModeloEntity mod = new ModeloEntity();
                        mod.NombreModelo= row.Cells[9].Value.ToString();
                        art.Modelo = mod;
                            total1 =  art.precio + total1;
                        art.total = total1;



                        newlista.Add(art);

                      
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Sistema Restaurante", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


               


            }
            xrReporteMateriales m;
            m = new xrReporteMateriales(newlista);

            m.ShowPreview();

        }
    }
}