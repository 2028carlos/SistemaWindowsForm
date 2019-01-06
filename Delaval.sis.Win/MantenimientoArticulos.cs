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
            pe.idArticulo = txtIdArticulo.Text;

            EquipoEntity eq = new EquipoEntity();
            eq.nombre = cboEquipo.SelectedValue.ToString();
            pe.Equipo = eq;

            ModeloEntity md = new ModeloEntity();
            md.NombreModelo = cboModelo.SelectedValue.ToString();
            pe.Modelo = md;

            if (txtCodigo.Text.Equals("") || txtPrecio.Text.Equals("") || txtUnidad.Text.Equals(""))
            {
                pe.codigo = 0;
                pe.precio = 0;
                pe.unidad = 0;
            }
            else
            {
                pe.codigo = Convert.ToInt32(txtCodigo.Text);
                pe.precio = Convert.ToDecimal(txtPrecio.Text);
                pe.unidad = Convert.ToInt32(txtUnidad.Text);
            }

            pe.descripcion = txtDescripcion.Text;
            pe.unidadmedida = cboUnidad.Text;

            pe.programa = cboPrograma.Text;



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

            eq.idEquipo = txtCodEquipo.Text;
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



        //GUARDAR DATOS   Modelo

        public String GuardarModelos(int op)
        {
            var resultado = "";
            me = new ModeloEntity();



            me.idModelos = txtCodModelo.Text;
            me.NombreModelo = txtNombreModelo.Text;

            if (op == 0)
            {
                resultado = "Insertado";
            }
            else
            {
                resultado = "Actualizado";
            }
            if (md.InsertandUpdateModelo(me, op) == 1)
            {
                resultado = "Datos agregados correctamente. ";
            }
            return resultado;

        }


        //LIMPIAR caja de texto  ARTICULO

        public void limpiar()
        {
            txtIdArticulo.Text = "";
            cboEquipo.Text = "";
            cboModelo.Text = "";
            txtCodigo.Text = "";
            txtDescripcion.Text = "";
            cboUnidad.Text = "";
            txtUnidad.Text = "";
            cboPrograma.Text = "";
            txtPrecio.Text = "";
        }

        //lIMPIAR CAJA EQUIPO

        public void limpiarEquipo()
        {
            txtCodEquipo.Text = "";
            txtEquipo.Text = "";
        }

        //LIMPIAR MODELO 
        public void limpiarModelo()
        {
            txtCodModelo.Text = "";
            txtNombreModelo.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            ListEquipos lq = new ListEquipos();
            lq.pasado += new ListEquipos.pasarEquipo(ejecutarListaEquipo);


            lq.Show();
        }
        public void ejecutarListaEquipo(EquipoEntity c)
        {

            txtCodEquipo.Text = c.idEquipo.ToString();
            txtEquipo.Text = c.nombre.ToString();



        }





        private void button9_Click(object sender, EventArgs e)
        {
            ListModelo lm = new ListModelo();
            lm.pasado += new ListModelo.pasarModelo(EjecutarListaModelo);
            lm.Show();
        }

        public void EjecutarListaModelo(ModeloEntity m)
        {
            txtCodModelo.Text = m.idModelos;
            txtNombreModelo.Text = m.NombreModelo.ToString();
        }

        private void MantenimientoArticulos_Load(object sender, EventArgs e)
        {
            ListarComboEquipo();
            ListarComboModelo();
            cboEquipo.Text = "";
            cboModelo.Text = "";
        }

        private void btnGuardarArticulos_Click(object sender, EventArgs e)
        {

            if (cboEquipo.Text.Equals("") || cboModelo.Text.Equals(""))
            {
                MessageBox.Show("Hay campos vacios revizar!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (txtIdArticulo.Text.Equals(""))
                {
                    MessageBox.Show(Guardar(0), "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show(Guardar(1), "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                limpiar();

            }




        }

        private void btnGuardarEquipo_Click(object sender, EventArgs e)
        {

            if (txtEquipo.Text.Equals(""))
            {
                MessageBox.Show("El campo no puede ser vacio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (txtCodEquipo.Text.Equals(""))
                {
                    MessageBox.Show(GuardarEquipos(0), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                }
                else
                {
                    MessageBox.Show(GuardarEquipos(1), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                }
                ListarComboEquipo();
                limpiarEquipo();




            }


        }

        private void btnListarArticulos_Click(object sender, EventArgs e)
        {
            ListArticulos a = new ListArticulos();
            a.pasado += new ListArticulos.pasar(ejecutarListaArticulo);
            a.Show();
        }

        public void ejecutarListaArticulo(ArticuloEntity c)
        {

            txtIdArticulo.Text = c.idArticulo.ToString();
            txtCodigo.Text = c.codigo.ToString();
            txtDescripcion.Text = c.descripcion;
            cboUnidad.Text = c.unidadmedida;

            txtUnidad.Text = c.unidad.ToString(); ;
            cboPrograma.Text = c.programa;
            txtPrecio.Text = c.precio.ToString();
            cboEquipo.Text = c.Equipo.nombre;
            cboModelo.Text = c.Modelo.NombreModelo;


        }

        private void btnGuardarModelo_Click(object sender, EventArgs e)
        {
            if (txtNombreModelo.Text.Equals(""))
            {
                MessageBox.Show("El campo no puede ser vacio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (txtCodModelo.Text.Equals(""))
                {
                    MessageBox.Show(GuardarModelos(0), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                }
                else
                {
                    MessageBox.Show(GuardarModelos(1), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                }
                ListarComboModelo();
                limpiarModelo();

            }
        }
    }
}
