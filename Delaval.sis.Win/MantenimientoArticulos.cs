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
        EquipoService es = new EquipoService();
        List<EquipoEntity> listaEquipo;
        ArticuloEntity pe;
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



        //GUARDAR DATOS 

        public String Guardar(int op)
        {
            var resultado = "";
            pe = new ArticuloEntity();

            pe.Equipo = Convert.ToInt32(cboEquipo.SelectedValue);
            pe.Modelo = Convert.ToInt32(cboModelo.Text);
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
        }

        private void btnGuardarArticulos_Click(object sender, EventArgs e)
        {
            Guardar(0);
        }
    }
}
