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
namespace Delaval.sis.Win
{
    public partial class MantenimientoArticulos : Form
    {
        ArticuloService ars = new ArticuloService();
        ModeloService md = new ModeloService();
        EquipoService es = new EquipoService();

        List<EquipoEntity> listaEquipo;
        List<ModeloEntity> listaModelo;

        ArticuloEntity pe;
        ModeloEntity me;
        EquipoEntity eq;

        public MantenimientoArticulos()
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

            cboEquipo.DataSource = new BindingSource(dicTemp, null);

            cboEquipo.DisplayMember = "Value";
            cboEquipo.ValueMember = "Key";
        }

        //LISTA COMBO MODELO
        public void ListarComboModelo()
        {
            listaModelo = new List<ModeloEntity>();
            listaModelo = md.listarModelos();
            Dictionary<int, String> dicTemp = new Dictionary<int, string>();

            foreach (var entidad in listaModelo)
            {

                dicTemp.Add(Convert.ToInt32(entidad.idModelos), entidad.NombreModelo);

            }

            cboModelo.DataSource = new BindingSource(dicTemp, null);

            cboModelo.DisplayMember = "Value";
            cboModelo.ValueMember = "Key";
        }


        //GUARDAR DATOS   Articulos

        public String Guardar(int op)
        {
            var resultado = "";
            pe = new ArticuloEntity();

            pe.Equipo = Convert.ToInt32(cboEquipo.SelectedValue);
            pe.Modelo = Convert.ToInt32(cboModelo.SelectedValue);
            pe.codigo = Convert.ToInt32(txtCodigo.Text);
            pe.descripcion = txtDescripcion.Text;
            pe.unidadmedida = cboUnidad.Text;
            pe.unidad = Convert.ToInt32(txtUnidad.Text);
            pe.programa = cboPrograma.Text;
            pe.precio = Convert.ToDecimal(txtPrecio.Text);



            if (op == 0)
            {
                resultado = "Insertado";
            }
            else
            {
                resultado = "Actualizado";
            }
            if (ars.InsertandUpdateAriculo(pe, op) == 1)
            {
                resultado = "Datos agregados correctamente. ";
            }
            return resultado;

        }

        //GUARDAR DATOS   Equipos

        public String GuardarEquipos(int op)
        {
            var resultado = "";
            eq = new EquipoEntity();

            //eq.idEquipo = Convert.ToInt32(txtCodEquipo.Text);
            eq.nombre = txtEquipo.Text;
           



            if (op == 0)
            {
                resultado = "Insertado";
            }
            else
            {
                resultado = "Actualizado";
            }
            if (es.InsertandUpdateEquipo(eq, op) == 1)
            {
                resultado = "Datos agregados correctamente. ";
            }
            return resultado;

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            ListEquipos lq = new ListEquipos();
            lq.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ListModelo lm = new ListModelo();
            lm.Show();
        }

        private void MantenimientoArticulos_Load(object sender, EventArgs e)
        {
            ListarComboEquipo();
            ListarComboModelo();
        }

        private void btnGuardarArticulos_Click(object sender, EventArgs e)
        {
            Guardar(0);
        }

        private void btnGuardarEquipo_Click(object sender, EventArgs e)
        {
            GuardarEquipos(0);
        }
    }
}
